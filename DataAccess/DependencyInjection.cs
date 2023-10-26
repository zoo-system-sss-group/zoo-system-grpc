using DataAccess.DAOs;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class DependencyInjections
{
    public static IServiceCollection AddDaoDIs(this IServiceCollection services)
    {
        services.AddSingleton<AccountDAO>();
        services.AddSingleton<AnimalDAO>();
        services.AddSingleton<AreaDAO>();
        services.AddSingleton<CageDAO>();
        services.AddSingleton<DietDAO>();
        services.AddSingleton<DietDetailDAO>();
        services.AddSingleton<NewsDAO>();
        services.AddSingleton<SpeciesDAO>();
        services.AddSingleton<TicketDAO>();
        services.AddSingleton<TicketOrderDAO>();
        return services;
    }
}
