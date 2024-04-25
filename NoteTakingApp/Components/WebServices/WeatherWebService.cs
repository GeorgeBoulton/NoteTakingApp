using NoteTakingApp.Components.Mappers;
using NoteTakingApp.Domain.Services;
using NoteTakingApp.Models;

namespace NoteTakingApp.Components.WebServices;

public class WeatherWebService(IWeatherService weatherService, IWeatherForecastMapper weatherForecastMapper) : IWeatherWebService
{
    public async Task<WeatherForecast[]> RetrieveContent()
    {
        var forecasts = await weatherService.Process();

        return forecasts.Select(weatherForecastMapper.Map).ToArray();
    }
}