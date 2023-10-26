using Domain.Enums;

namespace Grpc.DTOs;

public class TicketOrderCreateDTO
{
    public string CustomerName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public PaymentEnum PaymentMethod { get; set; } = default!;
    public List<TicketCreateDTO> Tickets { get; set; } = new List<TicketCreateDTO>();
}
