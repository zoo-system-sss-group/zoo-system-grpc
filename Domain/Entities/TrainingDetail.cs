namespace Domain.Entities;

public class TrainingDetail : BaseEntity
{
    public int TrainerId { get; set; }
    public int AnimalId { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; }
    public Account Trainer { get; set; } = default!;
    public AnimalInformation Animal { get; set; } = default!;
}
