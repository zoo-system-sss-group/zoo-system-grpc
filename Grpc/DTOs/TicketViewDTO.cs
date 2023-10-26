namespace Grpc.DTOs;

public class TicketViewDTO
{
    public int Id { get; set; }
    public Guid Code { get; set; }
    public double Price { get; set; }
    public DateTime EffectiveDate { get; set; }
    public string TypeCode { get; set; } = default!;
    public string TypeName { get; set; } = default!;
    public bool IsActive { get; set; }
    public int OrderId { get; set; }
}
