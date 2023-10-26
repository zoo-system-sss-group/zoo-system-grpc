namespace Grpc.DTOs;

public class TicketDTO
{
    public int Id { get; set; }
    public Guid Code { get; set; }
    public double Price { get; set; }
    public DateTime EffectiveDate { get; set; }
    public string TypeCode { get; set; } = default!;
    public string TypeName { get; set; } = default!;
    public bool IsActive { get; set; }
    public int OrderId { get; set; }
    public string CustomerName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
}
