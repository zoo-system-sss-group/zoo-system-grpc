using AutoMapper;
using Domain.Entities;
using Google.Protobuf;

namespace Grpc.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<byte[], string>().ConvertUsing<Base64Converter>();
            CreateMap<string, byte[]>().ConvertUsing<Base64Converter>();
            CreateMap<byte[], ByteString>().ReverseMap().ConvertUsing<Base64Converter>();

            CreateMap<NewsDTO, News>();
            CreateMap<News, NewsDTO>();
            CreateMap<UpdateNewsDTO, News>().ReverseMap();

        }
        private class Base64Converter : ITypeConverter<string, byte[]>, ITypeConverter<byte[], string>, ITypeConverter<byte[], ByteString>, ITypeConverter<ByteString, byte[]>
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
