using DataAccess.Commons;
using Domain.Entities;

namespace DataAccess.DAOs;

public class DietDAO : BaseDAO<Diet>
{
    public DietDAO(AppConfiguration configuration) : base(configuration)
    {
    }
}
