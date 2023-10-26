using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class TicketOrderDAO : BaseDAO<TicketOrder>
{
    private readonly AppConfiguration _configuration;
    public TicketOrderDAO(AppConfiguration configuration) : base(configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<TicketOrder>> GetAllTicketOrdersAsync()
    {
        var list = new List<TicketOrder>();
        using (var context = new AppDBContext(_configuration))
        {
            list = await context.TicketOrders
                    .Include(x => x.Tickets)
                    .ToListAsync();
        }
        return list;
    }

    public async Task<TicketOrder?> GetTicketOrderByIdAsync(int id)
    {
        TicketOrder? entity;
        using (var context = new AppDBContext(_configuration))
        {
            entity = await context.TicketOrders
                                    .Include(x => x.Tickets)
                                    .FirstOrDefaultAsync(x => x.Id == id);
        }
        return entity;
    }   
}
