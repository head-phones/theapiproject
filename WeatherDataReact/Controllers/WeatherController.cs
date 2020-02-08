using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Utilites;
using APILibrary.Utilities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace WeatherDataReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private static readonly string APIWebEndpoint = ConfigurationManager.GetConfiguration("APIWebEndpoint");
        protected readonly APIClient client = new APIClient(APIWebEndpoint);

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureHighF { get; set; }
            public int TemperatureLowF { get; set; }
            public string Summary { get; set; }

            public int TemperatureHighC
            {
                get
                {
                    return (int)(TemperatureHighF - 32) * 5/9;
                }
            }

            public int TemperatureLowC
            {
                get
                {
                    return (int)(TemperatureLowF - 32) * 5/9;
                }
            }
        }

        // GET Forecast
        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> Get(double lat = 30.455000, double lng = -84.253334)
        {
            var response = client.Get<APILibrary.DarkSky.Response>($"{lat},{lng}");

            return Enumerable.Range(1, 7).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureHighF = Convert.ToInt32(response.daily.data[index].temperatureHigh),
                TemperatureLowF = Convert.ToInt32(response.daily.data[index].temperatureLow),
                Summary = response.daily.data[index].summary
            });
        }

    }
}
