namespace Grpc.DTOs
{
    public class AnimalInformationDto
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public byte[]? Image { get; set; }
        public DateTime BirthDate { get; set; }
        public int SpeciesId { get; set; }
    }
}
