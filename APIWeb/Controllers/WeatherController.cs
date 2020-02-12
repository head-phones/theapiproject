using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Services;
using APILibrary.Utilites;
using APILibrary.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IDarkSkyService _api;
        public WeatherController(IDarkSkyService api)
        {
            _api = api;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return NotFound();
        }

        // GET Forecast
        [HttpGet("{lat},{lng}")]
        public ActionResult<APILibrary.DarkSky.Response> Get(decimal lat, decimal lng)
        {
            var function = $"{_api.APIKey}/{lat},{lng}";
            var response = _api.Get<APILibrary.DarkSky.Response>(function);

            return response;
        }
    }
}
