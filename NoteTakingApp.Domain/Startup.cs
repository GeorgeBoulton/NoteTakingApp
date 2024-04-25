using Microsoft.Extensions.DependencyInjection;
using NoteTakingApp.Domain.Services;

namespace NoteTakingApp.Domain;

public static class Startup
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddSingleton<IWeatherService, WeatherService>();
    }
}