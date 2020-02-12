using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Services;
using APILibrary.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeocodeController : ControllerBase
    {
        private IGoogleGeocodeService _api;
        public GeocodeController(IGoogleGeocodeService api)
        {
            _api = api;
        }

        [HttpGet("{address}")]
        public ActionResult<APILibrary.GoogleGeocode.Response> Geocode(string address)
        {
            var function = $"address={address}&key={_api.APIKey}";
            var response = _api.Get<APILibrary.GoogleGeocode.Response>(function);

            return response;
        }
        [HttpGet("ReverseGeocode/{lat},{lng}")]
        public ActionResult<APILibrary.GoogleGeocode.Response> ReverseGeocode(double lat, double lng)
        {
            var function = $"latlng={lat},{lng}&key={_api.APIKey}";
            var response = _api.Get<APILibrary.GoogleGeocode.Response>(function);

            return response;
        }
    }
}