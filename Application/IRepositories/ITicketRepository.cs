using Domain.Entities;

namespace Application.IRepositories;

public interface ITicketRepository
{
    Task<List<Ticket>> GetAllTicketsAsync();
    Task<Ticket?> GetTicketByIdAsync(int id);
    Task AddTicketAsync(Ticket ticket);
    Task AddTicketAsync(List<Ticket> tickets);
    Task UpdateTicketAsync(Ticket ticket);   
    Task DeleteTicketAsync(Ticket ticket);    
    Task SoftDeleteTicketAsync(Ticket ticket);    
}
