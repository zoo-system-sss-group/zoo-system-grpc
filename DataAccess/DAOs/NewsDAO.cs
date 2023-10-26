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
}
