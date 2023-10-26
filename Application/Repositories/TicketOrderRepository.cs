using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class TicketOrderRepository : ITicketOrderRepository
{
    private readonly TicketOrderDAO _ticketOrderDAO;

    public TicketOrderRepository(TicketOrderDAO ticketOrderDAO)
    {
        _ticketOrderDAO = ticketOrderDAO;
    }

    public async Task AddTicketOrderAsync(TicketOrder order)
    {
        var tmpTicketOrder = await _ticketOrderDAO.GetTicketOrderByIdAsync(order.Id);
        if (tmpTicketOrder != null)
        {
            throw new Exception("Duplicate TicketOrder Id.");
        }
        else
        {
            await _ticketOrderDAO.SaveAsync(order);
        }
    }

    public async Task DeleteTicketOrderAsync(TicketOrder order)
    {
        var tmpTicketOrder = await _ticketOrderDAO.GetTicketOrderByIdAsync(order.Id);
        if (tmpTicketOrder == null)
        {
            throw new Exception("TicketOrder Id does not exist.");
        }
        else
        {
            await _ticketOrderDAO.DeleteAsync(order);
        }
    }

    public async Task<List<TicketOrder>> GetAllTicketOrdersAsync()
        => await _ticketOrderDAO.GetAllTicketOrdersAsync();

    public async Task<TicketOrder?> GetTicketOrderByIdAsync(int id)
        => await _ticketOrderDAO.GetTicketOrderByIdAsync(id);

    public async Task SoftDeleteTicketOrderAsync(TicketOrder order)
    {
        var tmpTicketOrder = await _ticketOrderDAO.GetTicketOrderByIdAsync(order.Id);
        if (tmpTicketOrder == null)
        {
            throw new Exception("TicketOrder Id does not exist.");
        }
        else
        {
            await _ticketOrderDAO.SoftDeleteAsync(order);
        }
    }

    public async Task UpdateTicketOrderAsync(TicketOrder order)
    {
        var tmpTicketOrder = await _ticketOrderDAO.GetTicketOrderByIdAsync(order.Id);
        if (tmpTicketOrder == null)
        {
            throw new Exception("TicketOrder Id does not exist.");
        }
        else
        {
            await _ticketOrderDAO.UpdateAsync(order);
        }
    }
}
