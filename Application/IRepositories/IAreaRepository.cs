using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IAreaRepository
    {
        IQueryable<Area> GetAreasAsync();
        IQueryable<Area> GetAreaByIdAsync(int id);
        Task AddAreaAsync(Area area);
        Task UpdateAreaAsync(Area area);
        Task SoftDeleteAreaAsync(int id);
    }
}
