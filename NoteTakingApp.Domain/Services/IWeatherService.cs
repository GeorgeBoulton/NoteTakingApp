using NoteTakingApp.Domain.Models;

namespace NoteTakingApp.Domain.Services;

public interface IWeatherService
{
    Task<WeatherForecast[]> Process();
}