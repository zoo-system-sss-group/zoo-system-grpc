namespace Domain.Entities;

public class AnimalInformation : BaseEntity
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public double? Weight { get; set; }
    public double? Height { get; set; }
    public string? Image { get; set; }
    public DateTime BirthDate { get; set; }
    public int SpeciesId { get; set; }
    
    public Species Species { get; set; } = default!;
    public  ICollection<TrainingDetail> TrainingDetails { get; set; } = new List<TrainingDetail>();
    public ICollection<FeedHistory> FeedHistories { get; set; } = new List<FeedHistory>();
    public ICollection<CageHistory> CageHistories { get; set; } = new List<CageHistory>();
    public ICollection<DietDetail> DietDetails { get; set; } = new List<DietDetail>();
}
