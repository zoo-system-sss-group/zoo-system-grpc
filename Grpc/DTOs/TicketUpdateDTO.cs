namespace Grpc.DTOs;

public class TicketUpdateDTO
{
    public double Price { get; set; }
    public bool IsActive { get; set; } = true;
    public int TypeId { get; set; }
    public int OrderId { get; set; }
}
