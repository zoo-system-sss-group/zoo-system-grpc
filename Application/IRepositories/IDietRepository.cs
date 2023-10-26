using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IDietRepository
    {
        Task<List<Diet>> GetDietsAsync();
        Task<Diet?> GetDietByIdAsync(int id);
        Task<Diet?> GetCurrentDietByAnimalIdAsync(int id);
        Task AddDietAsync(Diet diet);
        Task UpdateDietAsync(Diet diet);
        Task SoftDeleteDietAsync(int id);
    }
}
