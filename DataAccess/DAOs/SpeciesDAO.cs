using DataAccess.Commons;
using Domain.Entities;

namespace DataAccess.DAOs;

public class SpeciesDAO : BaseDAO<Species>
{
    public SpeciesDAO(AppConfiguration configuration) : base(configuration)
    {
    }
}
