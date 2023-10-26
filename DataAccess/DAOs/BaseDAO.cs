using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class BaseDAO<TEntity> where TEntity : BaseEntity
{
    private AppConfiguration _configuration;

    public BaseDAO(AppConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        var list = new List<TEntity>();
        using (var context = new AppDBContext(_configuration))
        {
            list = await context.Set<TEntity>().ToListAsync();
        }
        return list;
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        TEntity? entity;
        using (var context = new AppDBContext(_configuration))
        {
            entity = await context.Set<TEntity>().FindAsync(id);
        }
        return entity;
    }
    public IQueryable<TEntity> GetAllOdataAsync()
    {
        IQueryable<TEntity> list;
        var context = new AppDBContext(_configuration);
        list =  context.Set<TEntity>();
        return list;
    }
    public IQueryable<TEntity> GetByIdOdataAsync(int id, bool queryAble = true)
    {
        IQueryable<TEntity> entity;
        var context = new AppDBContext(_configuration);
        entity =  context.Set<TEntity>().Where(x => x.Id == id);
        return entity;
    }

    public async Task SaveAsync(TEntity p)
    {
        using (var context = new AppDBContext(_configuration))
        {
            p.CreationDate = DateTime.Now;
            context.Set<TEntity>().Add(p);
            await context.SaveChangesAsync();
        }
    }

    public async Task SaveRangeAsync(List<TEntity> ls)
    {
        using (var context = new AppDBContext(_configuration))
        {
            DateTime now = DateTime.Now;
            ls.ForEach(x =>
            {
                x.CreationDate = now;
            });
            await context.Set<TEntity>().AddRangeAsync(ls);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateAsync(TEntity p)
    {
        using (var context = new AppDBContext(_configuration))
        {
            p.ModificationDate = DateTime.Now;
            context.Entry(p).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }

    public async Task DeleteAsync(TEntity p)
    {
        using (var context = new AppDBContext(_configuration))
        {
            context.Set<TEntity>().Remove(p);
            await context.SaveChangesAsync();
        }
    }

    public async Task SoftDeleteAsync(TEntity p)
    {
        using (var context = new AppDBContext(_configuration))
        {
            p.IsDeleted = true;
            p.DeletionDate = DateTime.Now;
            context.Entry(p).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
