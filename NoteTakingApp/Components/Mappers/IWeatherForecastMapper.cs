using NoteTakingApp.Models;

namespace NoteTakingApp.Components.Mappers;

public interface IWeatherForecastMapper
{
    WeatherForecast Map(Domain.Models.WeatherForecast weatherForecast);
}