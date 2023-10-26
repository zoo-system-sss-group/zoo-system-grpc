namespace Domain.Entities;

public class CageHistory : BaseEntity
{
    public int CageId { get; set; }
    public int AnimalId { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; }

    public Cage Cage { get; set; } = default!;
    public AnimalInformation Animal { get; set; } = default!;
}
