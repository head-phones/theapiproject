using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Utilites;
using APILibrary.Utilities;
using APILibrary.Vehicle;
using APILibrary.Vehicle.Makes;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private string Endpoint = ConfigurationManager.GetConfiguration("VehicleEndpoint");
        private string Token = "";

        [HttpGet]
        [Route("Makes")]
        public async Task<ActionResult<Response<IEnumerable<Make>>>> GetMakes()
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var function = $"vehicles/GetAllMakes?format=json";
                var response = await client.GetAsync<Response<IEnumerable<Make>>>(function);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("GetAllMakes")]
        public ActionResult<APILibrary.Vehicle.AllMakes.Response> GetAllMakes()
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var function = $"vehicles/GetAllMakes?format=json";
                var response = client.Get<APILibrary.Vehicle.AllMakes.Response>(function);
                return Ok(response);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("GetModelsByMakeName/{make}")]
        public ActionResult<APILibrary.Vehicle.ModelsByMake.Response> GetModelsByMakeName(string make)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var function = $"vehicles/GetModelsForMake/{make}?format=json";
                var response = client.Get<APILibrary.Vehicle.ModelsByMake.Response>(function);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("GetModelsByMakeID/{ID}")]
        public ActionResult<APILibrary.Vehicle.ModelsByMake.Response> GetModelsByMakeID(string ID)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var function = $"vehicles/GetModelsForMakeId/{ID}?format=json";
                var response = client.Get<APILibrary.Vehicle.ModelsByMake.Response>(function);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("GetVehicleTypesByMakeName/{make}")]
        public ActionResult<APILibrary.Vehicle.VehicleTypesByMake.Response> GetVehicleTypesByMakeName(string make)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var function = $"vehicles/GetVehicleTypesForMake/{make}?format=json";
                var response = client.Get<APILibrary.Vehicle.VehicleTypesByMake.Response>(function);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("GetVehicleTypesByMakeID/{ID}")]
        public ActionResult<APILibrary.Vehicle.VehicleTypesByMake.Response> GetVehicleTypesByMakeID(string ID)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {


                var function = $"vehicles/GetVehicleTypesForMakeId/{ID}?format=json";
                var response = client.Get<APILibrary.Vehicle.VehicleTypesByMake.Response>(function);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("GetMakesByVehicleTypeName/{vehicletype}")]
        public ActionResult<APILibrary.Vehicle.MakesByVehicleType.Response> GetMakesByVehicleTypeName(string vehicletype)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var function = $"vehicles/GetMakesForVehicleType/{vehicletype}?format=json";
                var response = client.Get<APILibrary.Vehicle.MakesByVehicleType.Response>(function);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("DecodeVIN/{vin}/{year}")]
        public ActionResult<APILibrary.Vehicle.DecodeVIN.Response> DecodeVIN(string vin, string year)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var function = $"vehicles/DecodeVin/{vin}?&modelyear={year}&format=json";
                var response = client.Get<APILibrary.Vehicle.DecodeVIN.Response>(function);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("GetAllVehicleVariables")]
        public ActionResult<APILibrary.Vehicle.AllVehicleVariables.Response> GetAllVehicleVariables()
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var function = $"vehicles/GetVehicleVariableList?format=json";
                var response = client.Get<APILibrary.Vehicle.AllVehicleVariables.Response>(function);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}