using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoData.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoData.Controllers
{
    public class VehicleVariablesController : BaseController
    {
        public VehicleVariablesController(IMapper mapper) : base(mapper) { }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var response = client.Get<APILibrary.Vehicle.AllVehicleVariables.Response>($"vehicle/GetAllVehicleVariables");
            var vehiclevariables = response.Results;
            var model = _mapper.Map<List<VehicleVariableViewModel>>(vehiclevariables);
            return PartialView("_List", model);
        }
    }
}