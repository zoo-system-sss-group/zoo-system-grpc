using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess;

public class AppDBContext : DbContext
{    
    private readonly AppConfiguration _appConfiguration;
    public AppDBContext(AppConfiguration appConfiguration)
    {
        _appConfiguration = appConfiguration;
    }
    public AppDBContext(DbContextOptions options, AppConfiguration appConfiguration) : base(options)
    {
        _appConfiguration = appConfiguration;
    }

    #region DB sets
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AnimalInformation> AnimalInformations { get; set; }
    public DbSet<Area> Areas { get; set; }
    public DbSet<Cage> Cages { get; set; }
    public DbSet<CageHistory> CageHistories { get; set; }
    public DbSet<Diet> Diets { get; set; }
    public DbSet<DietDetail> DietDetails { get; set; }
    public DbSet<FeedHistory> FeedHistories { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Species> Species { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketOrder> TicketOrders { get; set; }
    public DbSet<TrainingDetail> TrainingDetails { get; set; }
    #endregion

    // Connect DB
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_appConfiguration.ConnectionStrings.DefaultDB);
        }
    }

    // Get configurations from fluent api
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());        
    }

}
