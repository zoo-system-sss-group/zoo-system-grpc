namespace Domain.Entities;

public class Area : BaseEntity
{
    public string Code { get; set; } = default!; // A,B,C
    public string Name { get; set; } = default!;
    public string Location { get; set; } = default!;
    public string? Description { get; set; }
    public int Capacity { get; set; }    

    public ICollection<Cage> Cages { get; set; } = new List<Cage>();
}
