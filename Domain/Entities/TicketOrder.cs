using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class TicketOrder : BaseEntity
{
    public Guid Code { get; set; } = Guid.NewGuid();

    public string CustomerName { get; set; } = default!;
    [EmailAddress]
    public string Email { get; set; } = default!;
    
    [Phone]
    public string PhoneNumber { get; set; } = default!;
    public DateTime EffectiveDate { get; set; } // Vé cho hôm nào
    public PaymentEnum PaymentMethod { get; set; }
    
    public double TotalMoney { get; set; } = 0;
    
    public int TotalTicket { get; set; } = 0;
    [EnumDataType(typeof(OrderStatusEnum))]

    public OrderStatusEnum Status { get; set; } = OrderStatusEnum.Success;

    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
