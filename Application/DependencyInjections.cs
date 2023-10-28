using Application.IRepositories;
using Application.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class DependencyInjections
{
    public static IServiceCollection AddRepositoryDIs(this IServiceCollection services)
    {
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<INewsRepository, NewsRepository>();
        services.AddScoped<ISpeciesRepository, SpeciesRepository>();
        services.AddScoped<IAnimalRepository, AnimalRepsository>();
        services.AddScoped<IAreaRepository, AreaRepository>();
        services.AddScoped<ICageRepository, CageRepository>();
        services.AddScoped<IDietRepository, DietRepository>();
        services.AddScoped<ITicketRepository, TicketRepository>();
        services.AddScoped<ITicketOrderRepository, TicketOrderRepository>();
        //IEnumerable<Type> enumerable = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.Name.EndsWith("Repository") && x.IsClass);
        //foreach (var item in enumerable)
        //{
        //    var @interface= item.GetInterface("I" + item.Name);
        //    services.AddScoped(@interface,item);
        //}
        return services;
    }
}
