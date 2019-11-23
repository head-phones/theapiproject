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
    public class VehicleController : Controller
    {
        private string Endpoint = ConfigurationManager.GetConfiguration("VehicleEndpoint");
        private string Token = "";

        [HttpGet]
        [Route("GetAllMakes")]
        public ActionResult<APILibrary.Vehicle.AllMakes.Response> GetAllMakes()
        {
            var client = new APIClient(Endpoint, Token);

            var function = $"vehicles/GetAllMakes?format=json";
            var response = client.Get<APILibrary.Vehicle.AllMakes.Response>(function);

            return response;
        }

        [HttpGet("GetModelsByMakeName/{make}")]
        public ActionResult<APILibrary.Vehicle.ModelsByMakeName.Response> GetModelsByMakeName(string make)
        {
            var client = new APIClient(Endpoint, Token);

            var function = $"vehicles/GetModelsForMake/{make}?format=json";
            var response = client.Get<APILibrary.Vehicle.ModelsByMakeName.Response>(function);

            return response;
        }

        [HttpGet("GetMakesByVehicleTypeName/{vehicletype}")]
        public ActionResult<APILibrary.Vehicle.MakesByVehicleTypeName.Response> GetMakesByVehicleTypeName(string vehicletype)
        {
            var client = new APIClient(Endpoint, Token);

            var function = $"vehicles/GetMakesForVehicleType/{vehicletype}?format=json";
            var response = client.Get<APILibrary.Vehicle.MakesByVehicleTypeName.Response>(function);

            return response;
        }
    }
}