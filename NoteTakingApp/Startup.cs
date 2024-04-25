using NoteTakingApp.Components.Mappers;
using NoteTakingApp.Components.WebServices;
using NoteTakingApp.Domain.Services;

namespace NoteTakingApp;

public static class Startup
{
    public static void AddServices(this IServiceCollection services)
    {
        DAL.Startup.AddServices(services);
        Domain.Startup.AddServices(services);
        
        services.AddMappers();
        services.AddWebServices();
    }

    private static void AddMappers(this IServiceCollection services)
    {
        services.AddSingleton<IWeatherForecastMapper, WeatherForecastMapper>();
    }

    private static void AddWebServices(this IServiceCollection services)
    {
        services.AddSingleton<IWeatherWebService, WeatherWebService>();
    }
}