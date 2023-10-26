using DataAccess.Commons;
using Domain.Entities;

namespace DataAccess.DAOs;

public class AnimalDAO : BaseDAO<AnimalInformation>
{
    public AnimalDAO(AppConfiguration configuration) : base(configuration)
    {
    }
}
