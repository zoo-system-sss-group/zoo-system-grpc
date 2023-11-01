using Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Application.IRepositories;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AutoMapper;
using Domain.Entities;
using DataAccess.Utils;
using System;
using System.Text.Json;
using System.Data;
using Microsoft.IdentityModel.Tokens;
using DataAccess.Commons;

public class NewsServiceImpl : NewsService.NewsServiceBase
{
    public required INewsRepository _repository;
    public required IMapper _mapper;
    private readonly AppConfiguration _configuration;

    public NewsServiceImpl(INewsRepository repository, IMapper mapper,AppConfiguration configuration)
    {
        _repository = repository;
        _mapper = mapper;
        _configuration = configuration;
    }

    public override async Task GetNews(Search request, IServerStreamWriter<Grpc.NewsDTO> responseStream, ServerCallContext context)
    {
        Console.WriteLine($"GetNews: {request. Search_}");
        var news = await _repository.GetNews(request.Search_);
        foreach (var @new in news)
        {
            var newsDto = Map(@new);
            Console.WriteLine(string.Concat(newsDto.ToString().AsSpan(1, 100), "..."));
            await responseStream.WriteAsync(newsDto);
        }
    }
    public override async Task GetRandomNews(NewsId request, IServerStreamWriter<NewsDTO> responseStream, ServerCallContext context)
    {
        var news = await _repository.GetRandomNews(request.Id);
        Console.WriteLine("GetRandomNews");
        foreach (var @new in news)
        {
            var newsDto = Map(@new);
            Console.WriteLine(string.Concat(newsDto.ToString().AsSpan(1, 100), "..."));
            await responseStream.WriteAsync(newsDto);
        }
    }

    public override async Task<Grpc.NewsDTO> GetNewById(NewsId request, ServerCallContext context)
    {
        Console.WriteLine("GetNewById");
        var news = await _repository.GetNews(request.Id);
        if (news == null) throw new KeyNotFoundException($"news {request.Id} Not Found!");
        var newsDto = Map(@news);
        return newsDto;
    }
    public override async Task<StringMessage> CreateNews(Grpc.CreateNewsDTO request, ServerCallContext context)
    {
        Console.WriteLine("CreateNews: " + request);

        var user = await GetUser(context.RequestHeaders.GetValue("authorization") ?? "");
        if (user == null) throw new RpcException(new Status(StatusCode.Unauthenticated, "User not logged in"));
        if (user.Role != Domain.Enums.RoleEnum.Staff) throw new RpcException(new Status(StatusCode.PermissionDenied, $"{user.Role} not allowed to use this method"));

        var news = _mapper.Map<News>(request);
        await _repository.AddNews(news);
        return new StringMessage { Message = $"News {news.Title} Created!" };
    }
    public override async Task<StringMessage> UpdateNews(UpdateNewsDTO request, ServerCallContext context)
    {
        Console.WriteLine("UpdateNews: " + request);
        var user = await GetUser(context.RequestHeaders.GetValue("authorization") ?? "");

        if (user == null) throw new RpcException(new Status(StatusCode.Unauthenticated, "User not logged in"));
        if (user.Role != Domain.Enums.RoleEnum.Staff) throw new RpcException(new Status(StatusCode.PermissionDenied, $"{user.Role} not allowed to use this method"));

        var news = await _repository.GetNews(request.Id);
        _ = news ?? throw new RpcException(new Status(StatusCode.Aborted, $"News {request.Id} Not Found!"));
        news = _mapper.Map<UpdateNewsDTO, News>(request, news);
        await _repository.UpdateNews(news);
        return new StringMessage { Message = $"News {news.Title} Updated!" };
    }
    public override async Task<StringMessage> RemoveNews(NewsId request, ServerCallContext context)
    {
        Console.WriteLine($"RemoveNews: {request.Id}");
        var user = await GetUser(context.RequestHeaders.GetValue("authorization") ?? "");
        if (user == null) throw new RpcException(new Status(StatusCode.Unauthenticated, "User not logged in"));
        if (user.Role != Domain.Enums.RoleEnum.Staff) throw new RpcException(new Status(StatusCode.PermissionDenied, $"{user.Role} not allowed to use this method"));
     
        var news = await _repository.GetNews(request.Id);
        _ = news ?? throw new RpcException( new Status(StatusCode.Aborted,$"News {request.Id} Not Found!"));
        await _repository.DeleteNews(news);
        return new StringMessage { Message = $"News {news.Title} Removed!" };
    }
    private NewsDTO Map(News news)
    {
        var newDtos = _mapper.Map<News, Grpc.NewsDTO>(news);
        newDtos.CreationDate = DateTimeConverter.ToTimeSpamp(news.CreationDate.Value);
        if (news.ModificationDate != null)
            newDtos.ModificationDate = DateTimeConverter.ToTimeSpamp(news.ModificationDate.Value);
        return newDtos;
    }
    private async Task<Account?> GetUser(string token)
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        var response = await client.GetAsync(_configuration.AuthorizationAPIs.CurrentUser);
        if (response.IsSuccessStatusCode)
        {
            var strData = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Account>(strData) ?? null;
        }
        if (response.StatusCode == (System.Net.HttpStatusCode)401)
        {
            return null;
        }
        throw new RpcException(new Status(StatusCode.Aborted, "Main server not loaded!"));
    }
}
