using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class CageDAO : BaseDAO<Cage>
{
    private readonly AppConfiguration _configuration;
    public CageDAO(AppConfiguration configuration) : base(configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<Cage>?> GetCageByAreaId(int id)
    {
        List<Cage>? cages;
        using (var context = new AppDBContext(_configuration))
        {
            cages = await context.Cages.Where(c => c.AreaId == id).ToListAsync();
        }
        return cages;
    }
}
