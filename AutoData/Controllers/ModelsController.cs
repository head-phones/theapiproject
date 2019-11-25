using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoData.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoData.Controllers
{
    public class ModelsController : BaseController
    {
        public ModelsController(IMapper mapper) : base(mapper) { }

        public IActionResult Index(string make)
        {
            ViewData["make"] = make;
            return View();
        }

        public IActionResult List(string make)
        {
            ViewData["make"] = make;
            var response = client.Get<APILibrary.Vehicle.ModelsByMake.Response>($"vehicle/GetModelsByMakeName/{make}");
            var models = response.Results;
            var model = _mapper.Map<List<ModelViewModel>>(models);
            return PartialView("_List", model);
        }
    }
}
