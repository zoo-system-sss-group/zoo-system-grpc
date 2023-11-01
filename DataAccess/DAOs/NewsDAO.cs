using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System;
using DataAccess.Commons;

namespace DataAccess.DAOs;

public class NewsDAO : BaseDAO<News>
{
    public NewsDAO(AppConfiguration configuration) : base(configuration)
    {
    }

    public async Task<List<News>> GetAllAsync(string search)
    {
        var queryable = base.GetAllOdataAsync().Where(x=>x.IsDeleted == false && x.Title.Contains(search) || x.Content.Contains(search));
        return await queryable.ToListAsync();
    }
}
