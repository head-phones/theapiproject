using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Utilites;
using APILibrary.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private string Endpoint = ConfigurationManager.GetConfiguration("DarkSkyEndpoint");
        private string Token = ConfigurationManager.GetConfiguration("DarkSkySecretKey");

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET Forecast
        [HttpGet("{lat},{lng}")]
        public ActionResult<APILibrary.DarkSky.Response> Get(decimal lat, decimal lng)
        {
            var client = new ApiExtensions(Endpoint, Token);

            var function = $"{Token}/{lat},{lng}";
            var response = client.Get<APILibrary.DarkSky.Response>(function);

            return response;
        }
    }
}
