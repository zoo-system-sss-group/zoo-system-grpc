namespace Grpc.DTOs;

public class TicketOrderViewDTO
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public DateTime CreatedDate { get; set; }
    public string PaymentMethod { get; set; } = default!;
    public double Total { get; set; }
    public byte Status { get; set; }
    public List<TicketViewDTO> Tickets { get; set; } = new List<TicketViewDTO>();
}
