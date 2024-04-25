using NoteTakingApp.Models;

namespace NoteTakingApp.Components.WebServices;

public interface IWeatherWebService
{
    Task<WeatherForecast[]> RetrieveContent();
}