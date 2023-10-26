namespace Grpc.DTOs
{
    public class AreaDto
    {
        public string Name { get; set; } = default!;
        public string Location { get; set; } = default!;
        public string? Description { get; set; }
        public int Capacity { get; set; }
    }
}
