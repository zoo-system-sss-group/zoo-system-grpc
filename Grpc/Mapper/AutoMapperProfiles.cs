using AutoMapper;
using Domain.Entities;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System.ComponentModel;

namespace Grpc.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<byte[], string>().ConvertUsing<Base64Converter>();
            CreateMap<string, byte[]>().ConvertUsing<Base64Converter>();
            CreateMap<byte[], ByteString>().ReverseMap().ConvertUsing<Base64Converter>();
            CreateMap<DateTime, Timestamp>().ReverseMap().ConvertUsing<DateTimeConverter>();
            CreateMap<NewsDTO, News>()
                .ForMember(x => x.CreationDate, src => src.MapFrom(y => y.CreationDate))
                .ForMember(x => x.ModificationDate, src => src.MapFrom(y => y.ModificationDate))
                .ReverseMap();
            CreateMap<UpdateNewsDTO, News>().ReverseMap();
            CreateMap<CreateNewsDTO, News>().ReverseMap();

        }
        private class DateTimeConverter : ITypeConverter<DateTime, Timestamp>, ITypeConverter<Timestamp, DateTime>
        {

            public Timestamp Convert(DateTime source, Timestamp destination, ResolutionContext context)
            {
                return source.ToTimestamp();
            }

            public DateTime Convert(Timestamp source, DateTime destination, ResolutionContext context)
            {
                return source.ToDateTime();
            }
        }
        private class Base64Converter : ITypeConverter<string, byte[]>, ITypeConverter<byte[], string>,
            ITypeConverter<byte[], ByteString>, ITypeConverter<ByteString, byte[]>
        {
            public byte[] Convert(string source, byte[] destination, ResolutionContext context)
                => System.Convert.FromBase64String(source);

            public string Convert(byte[] source, string destination, ResolutionContext context)
                => System.Convert.ToBase64String(source);

            public byte[] Convert(ByteString source, byte[] destination, ResolutionContext context)
            {
                return source.ToByteArray();
            }

            public ByteString Convert(byte[] source, ByteString destination, ResolutionContext context)
            {
                if (source == null) return ByteString.Empty;
                return ByteString.FromBase64(System.Convert.ToBase64String(source));
            }


        }

    }
}
