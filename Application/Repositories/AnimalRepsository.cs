using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class AnimalRepsository : IAnimalRepository
{
    private readonly AnimalDAO _animalDao;

    public AnimalRepsository(AnimalDAO animalDao)
    {
        _animalDao = animalDao;
    }

    public IQueryable<AnimalInformation> GetAnimalsAsync()
        => _animalDao.GetAllOdataAsync();

    public IQueryable<AnimalInformation> GetAnimalByIdAsync(int id)
        => _animalDao.GetByIdOdataAsync(id);

    public async Task AddAnimalsAsync(AnimalInformation animal)
        => await _animalDao.SaveAsync(animal);

    public async Task UpdateAnimalAsync(AnimalInformation animal)
    {
        var result = await _animalDao.GetByIdAsync(animal.Id);
        if (result == null)
            throw new Exception("Can not found!");
        await _animalDao.UpdateAsync(animal);
    }

    public async Task SoftDeleteAnimalsAsync(int id)
    {
        var result = await _animalDao.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
        await _animalDao.SoftDeleteAsync(result);
    }
}
