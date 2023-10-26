namespace Domain.Entities;

public class News : BaseEntity
{
    public string Title { get; set; } = default!;
    public byte[]? Thumbnail { get; set; }
    public string Content { get; set; } = default!;    
}
