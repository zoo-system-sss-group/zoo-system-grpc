using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class TicketDAO : BaseDAO<Ticket>
{
    private readonly AppConfiguration _configuration;
    public TicketDAO(AppConfiguration configuration) : base(configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<Ticket>> GetAllTicketDetailsAsync()
    {
        var tickets = new List<Ticket>();
        using (var context = new AppDBContext(_configuration))
        {
            tickets = await context.Tickets
                            .Include(x => x.OrderInformation)
                            .ToListAsync();
        }
        return tickets;
    }
}
