using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WeatherDataAngular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IApiService _api;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IApiService api)
        {
            _logger = logger;
            _api = api;
        }

        [HttpGet]
        public WeatherForecast Get(double lat, double lng)
        {
            var weatherResult = _api.Get<APILibrary.DarkSky.Response>($"Weather/{lat},{lng}");
            var forecast = new WeatherForecast(weatherResult);
            return forecast;
        }
    }
}
