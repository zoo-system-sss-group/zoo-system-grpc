using Domain.Enums;

namespace Domain.Entities;

public class Species : BaseEntity
{
    public string Name { get; set; } = default!;
    public string ScientificName { get; set; } = default!;
    public int LifeSpan { get; set; }
    public string? Description { get; set; }
    public string? WildDiet { get; set; }
    public HabitatEnum Habitat { get; set; }

    public ICollection<AnimalInformation> Animals { get; set; } = new List<AnimalInformation>();
}
