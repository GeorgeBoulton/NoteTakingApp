using NoteTakingApp.Models;

namespace NoteTakingApp.Components.Mappers;

public class WeatherForecastMapper : IWeatherForecastMapper
{
    public WeatherForecast Map(Domain.Models.WeatherForecast weatherForecast) => new(
            weatherForecast.Date,
            weatherForecast.TemperatureC,
            weatherForecast.Summary,
            weatherForecast.TemperatureF
    );
}