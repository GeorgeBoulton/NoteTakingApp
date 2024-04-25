using NoteTakingApp.Models;

namespace NoteTakingApp.Components.Pages;

public partial class Weather
{
    private WeatherForecast[]? _forecasts;

    protected override async Task OnInitializedAsync()
    {
        _forecasts = await WeatherWebService.RetrieveContent();
    }
}