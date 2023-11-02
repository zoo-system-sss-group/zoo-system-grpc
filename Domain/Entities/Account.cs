using Domain.Enums;

namespace Domain.Entities;
public class Account : BaseEntity
{
    public string Username { get; set; } = default!;
    public string Password { get; set; } = default!;
    public RoleEnum Role { get; set; }
    public string? Avatar { get; set; }
    public string? Fullname { get; set; }
    public string? Experiences { get; set; }
    
    public ICollection<TrainingDetail> TrainingDetails { get; set; } = new List<TrainingDetail>();
    public ICollection<FeedHistory> FeedHistories { get; set; } = new List<FeedHistory>();    
}
