namespace Domain.Entities;

public class DietDetail : BaseEntity
{
    public int AnimalId { get; set; }
    public int DietId { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; }

    public AnimalInformation Animal { get; set; } = default!;
    public Diet Diet { get; set; } = default!;
}
