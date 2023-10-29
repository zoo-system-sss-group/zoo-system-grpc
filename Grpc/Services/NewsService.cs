using Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Application.IRepositories;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AutoMapper;
using Domain.Entities;

public class NewsServiceImpl : NewsService.NewsServiceBase
{
    public required INewsRepository _repository;
    public required IMapper _mapper;

    public NewsServiceImpl(INewsRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public override async Task GetNews(Empty request, IServerStreamWriter<Grpc.NewsDTO> responseStream, ServerCallContext context)
    {
        var news = await _repository.GetNews();
        var newDtos = _mapper.Map<List<News>, List<Grpc.NewsDTO>>(news);
        Console.WriteLine("GetNews");
        foreach (var newsDto in newDtos)
        {
            await responseStream.WriteAsync(newsDto);
        }
    }

    public override async Task<Grpc.NewsDTO> GetNewById(NewsId request, ServerCallContext context)
    {
        Console.WriteLine("GetNewById");
        var news = await _repository.GetNews(request.Id);
        if (news == null) throw new KeyNotFoundException($"news {request.Id} Not Found!");
        var newsDto = _mapper.Map<News, Grpc.NewsDTO>(news);
        return newsDto;
    }
    public override async Task<StringMessage> CreateNews(Grpc.CreateNewsDTO request, ServerCallContext context)
    {
        Console.WriteLine("CreateNews");
        var news = _mapper.Map<News>(request);
        await _repository.AddNews(news);
        return new StringMessage { Message = "News Created!" };
    }
    public override async Task<StringMessage> UpdateNews(UpdateNewsDTO request, ServerCallContext context)
    {
        Console.WriteLine("UpdateNews");
        var news = _mapper.Map<News>(request);
        await _repository.UpdateNews(news);
        return new StringMessage { Message = "News Updated!" };
    }
    public override async Task<StringMessage> RemoveNews(NewsId request, ServerCallContext context)
    {
        Console.WriteLine("RemoveNews");
        var news = await _repository.GetNews(request.Id);
        await _repository.DeleteNews(news);
        return new StringMessage { Message = "News Removed!" };
    }
}
