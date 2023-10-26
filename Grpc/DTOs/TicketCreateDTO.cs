namespace Grpc.DTOs;

public class TicketCreateDTO
{
    public string TypeCode { get; set; } = default!;
    public DateTime EffectiveDate { get; set; }
    public int Quantity { get; set; } = 1;
}
