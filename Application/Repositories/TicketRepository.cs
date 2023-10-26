using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly TicketDAO _ticketDAO;

    public TicketRepository(TicketDAO ticketDAO)
    {
        _ticketDAO = ticketDAO;
    }

    public async Task AddTicketAsync(Ticket ticket)
    {
        var tmpTicket = await _ticketDAO.GetByIdAsync(ticket.Id);
        if (tmpTicket != null)
        {
            throw new Exception("Duplicate ticket Id.");
        } else
        {
            await _ticketDAO.SaveAsync(ticket);
        }        
    }        

    public async Task DeleteTicketAsync(Ticket ticket)
    {
        var tmpTicket = await _ticketDAO.GetByIdAsync(ticket.Id);
        if (tmpTicket == null)
        {
            throw new Exception("Ticket Id does not exist.");
        }
        else
        {
            await _ticketDAO.DeleteAsync(ticket);
        }
    }

    public async Task<List<Ticket>> GetAllTicketsAsync()
        => await _ticketDAO.GetAllTicketDetailsAsync();    

    public async Task<Ticket?> GetTicketByIdAsync(int id)
        => await _ticketDAO.GetByIdAsync(id);    

    public async Task SoftDeleteTicketAsync(Ticket ticket)
    {
        var tmpTicket = await _ticketDAO.GetByIdAsync(ticket.Id);
        if (tmpTicket == null)
        {
            throw new Exception("Ticket Id does not exist.");
        }
        else
        {
            await _ticketDAO.SoftDeleteAsync(ticket);
        }
    }

    public async Task UpdateTicketAsync(Ticket ticket)
    {
        var tmpTicket = await _ticketDAO.GetByIdAsync(ticket.Id);
        if (tmpTicket == null)
        {
            throw new Exception("Ticket Id does not exist.");
        }
        else
        {
            await _ticketDAO.UpdateAsync(ticket);
        }
    }    

    public async Task AddTicketAsync(List<Ticket> tickets)
        => await _ticketDAO.SaveRangeAsync(tickets);    
}
