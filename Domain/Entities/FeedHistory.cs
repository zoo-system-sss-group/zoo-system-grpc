namespace Domain.Entities;

public class FeedHistory : BaseEntity
{
    public int TrainerId { get; set; }
    public int AnimalId { get; set; }
    public DateTime FeedingDate { get; set; } = DateTime.Now;

    public Account Trainer { get; set; } = default!;
    public AnimalInformation Animal { get; set; } = default!;
}
