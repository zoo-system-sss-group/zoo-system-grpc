using AutoMapper;
using Domain.Entities;
using Grpc.DTOs;

namespace Grpc.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<NewsDTO, DTOs.NewsDTO>().ReverseMap();
            CreateMap<NewsDTO, Domain.Entities.News>().ReverseMap();
            CreateMap<Domain.Entities.News,News>().ReverseMap();

        }
    }
}
