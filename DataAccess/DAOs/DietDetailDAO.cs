using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class DietDetailDAO : BaseDAO<DietDetail>
{
    private readonly AppConfiguration _configuration;
    public DietDetailDAO(AppConfiguration configuration) : base(configuration)
    {
        _configuration = configuration;
    }

    public async Task<DietDetail?> GetDietDetailByAnimalId(int id)
    {
        List<DietDetail>? dietDetails;
        using (var context = new AppDBContext(_configuration))
        {
            dietDetails = await context.DietDetails.Where(ch => ch.AnimalId == id && ch.EndDate == null).ToListAsync();
        }
        return dietDetails[0];
    }

}
