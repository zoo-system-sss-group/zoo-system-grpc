namespace Domain.Entities;

public class Cage : BaseEntity
{
    public string Code { get; set; } = default!; 
    public string Name { get; set; } = default!;
    public string Location { get; set; } = default!;
    public byte[]? Image { get; set; }
    public int Capacity { get; set; }
    public string? Description { get; set; }
    public int AreaId { get; set; }

    public Area Area { get; set; } = default!;
    public ICollection<CageHistory> CageHistories { get; set; } = new List<CageHistory>();
}
