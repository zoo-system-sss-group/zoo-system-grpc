using DataAccess.DAOs;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DataAccess;

public static class DependencyInjections
{
    public static IServiceCollection AddDaoDIs(this IServiceCollection services)
    {
        //services.AddSingleton<AccountDAO>();
        //services.AddSingleton<AnimalDAO>();
        //services.AddSingleton<AreaDAO>();
        //services.AddSingleton<CageDAO>();
        //services.AddSingleton<DietDAO>();
        //services.AddSingleton<DietDetailDAO>();
        //services.AddSingleton<NewsDAO>();
        //services.AddSingleton<SpeciesDAO>();
        //services.AddSingleton<TicketDAO>();
        //services.AddSingleton<TicketOrderDAO>();
        IEnumerable<Type> enumerable = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.Name.EndsWith("DAO"));
        foreach (var item in enumerable)
        {
        services.AddSingleton(item);

        }
        return services;
    }
}
