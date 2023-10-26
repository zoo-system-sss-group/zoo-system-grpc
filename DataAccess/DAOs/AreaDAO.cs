using DataAccess.Commons;
using Domain.Entities;

namespace DataAccess.DAOs;

public class AreaDAO : BaseDAO<Area>
{
    public AreaDAO(AppConfiguration configuration) : base(configuration)
    {
    }
}
