using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface ICageRepository
    {
        IQueryable<Cage> GetCagesAsync();
        IQueryable<Cage> GetCageByIdAsync(int id);
        Task AddCageAsync(Cage cage);
        Task UpdateCageAsync(Cage cage);
        Task SoftDeleteCageAsync(int id);
    }
}
