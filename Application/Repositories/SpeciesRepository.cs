using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class SpeciesRepository : ISpeciesRepository
{
    private readonly SpeciesDAO _speciesDAO;

    public SpeciesRepository(SpeciesDAO speciesDAO)
    {
        _speciesDAO = speciesDAO;
    }

    public IQueryable<Species> GetSpeciesAsync()
        =>  _speciesDAO.GetAllOdataAsync();

    public IQueryable<Species> GetSpeciesByIdAsync(int id)
        =>  _speciesDAO.GetByIdOdataAsync(id);

    public async Task AddSpeciesAsync(Species species)
        => await _speciesDAO.SaveAsync(species);

    public async Task UpdateSpeciesAsync(Species species)
    {
        var result = await _speciesDAO.GetByIdAsync(species.Id);
        if (result == null)
            throw new Exception("Can not found!");
        await _speciesDAO.UpdateAsync(species);
    }

    public async Task SoftDeleteSpeciesAsync(int id)
    {
        var result = await _speciesDAO.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
        await _speciesDAO.SoftDeleteAsync(result);
    }
}
