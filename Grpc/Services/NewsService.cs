using Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Application.IRepositories;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AutoMapper;
using Grpc.DTOs;

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
        var newDtos = _mapper.Map<List<Domain.Entities.News>, List<Grpc.NewsDTO>>(news);
        newDtos.ForEach(x =>
        {
            responseStream.WriteAsync(x);
        });
    }
}
