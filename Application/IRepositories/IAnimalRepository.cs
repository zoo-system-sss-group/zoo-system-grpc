using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IAnimalRepository
    {
        IQueryable<AnimalInformation> GetAnimalsAsync();
        IQueryable<AnimalInformation> GetAnimalByIdAsync(int id);
        Task AddAnimalsAsync(AnimalInformation animal);
        Task UpdateAnimalAsync(AnimalInformation animal);
        Task SoftDeleteAnimalsAsync(int id);
    }
}
