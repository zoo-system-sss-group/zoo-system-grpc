using Domain.Enums;

namespace Grpc.DTOs
{
    public class SpeciesDto
    {
        public string Name { get; set; } = default!;
        public string ScientificName { get; set; } = default!;
        public int LifeSpan { get; set; }
        public string? Description { get; set; }
        public string? WildDiet { get; set; }
        public HabitatEnum Habitat { get; set; }
    }
}
