using Application.IRepositories;
using Azure;
using DataAccess.DAOs;
using Domain.Entities;
using System.Collections;

namespace Application.Repositories;

public class CageRepository : ICageRepository
{
    private readonly CageDAO _cageDAO;
    private readonly AnimalDAO _animalDao;

    public CageRepository(CageDAO cageDAO, AnimalDAO animalDao)
    {
        _cageDAO = cageDAO;
        _animalDao = animalDao;
    }

    public IQueryable<Cage> GetCagesAsync()
        => _cageDAO.GetAllOdataAsync();

    public IQueryable<Cage> GetCageByIdAsync(int id)
    {
        var result = _cageDAO.GetByIdOdataAsync(id);
        return result;
    }

    public async Task AddCageAsync(Cage cage)
        => await _cageDAO.SaveAsync(cage);

    public async Task UpdateCageAsync(Cage cage)
    {
        var result = await _cageDAO.GetByIdAsync(cage.Id);
        if (result == null)
            throw new Exception("Can not found!");
        await _cageDAO.UpdateAsync(cage);
    }

    public async Task SoftDeleteCageAsync(int id)
    {
        var result = await _cageDAO.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
        await _cageDAO.SoftDeleteAsync(result);
    }
}
