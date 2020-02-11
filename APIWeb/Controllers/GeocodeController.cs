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
        private string Endpoint = ConfigurationManager.GetConfiguration("GoogleGeocodeEndpoint");
        private string Key = ConfigurationManager.GetConfiguration("GoogleApiKey");

        [HttpGet("{address}")]
        public ActionResult<APILibrary.GoogleGeocode.Response> Geocode(string address)
        {
            var client = new ApiService(Endpoint, Key);

            var function = $"address={address}&key={Key}";
            var response = client.Get<APILibrary.GoogleGeocode.Response>(function);

            return response;
        }
        [HttpGet("ReverseGeocode/{lat},{lng}")]
        public ActionResult<APILibrary.GoogleGeocode.Response> ReverseGeocode(double lat, double lng)
        {
            var client = new ApiService(Endpoint, Key);

            var function = $"latlng={lat},{lng}&key={Key}";
            var response = client.Get<APILibrary.GoogleGeocode.Response>(function);

            return response;
        }
    }
}