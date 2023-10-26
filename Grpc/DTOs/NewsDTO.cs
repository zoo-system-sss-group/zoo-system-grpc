using System.ComponentModel.DataAnnotations;

namespace Grpc.DTOs
{
    public class NewsDTO
    {
        [StringLength(30)]
        public string Title { get; set; } = default!;
        public byte[]? Thumbnail { get; set; }
        public string Content { get; set; } = default!;
    }
}
