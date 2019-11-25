using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoData.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoData.Controllers
{
    public class ModelsController : BaseController
    {
        public IActionResult Index(string make)
        {
            ViewData["make"] = make;
            return View();
        }

        public IActionResult List(string make)
        {
            ViewData["make"] = make;
            var response = client.Get<APILibrary.Vehicle.ModelsByMake.Response>($"vehicle/GetModelsByMakeName/{make}");
            var model = new List<ModelViewModel>();
            var makes = response.Results;
            model = makes?.Select(m => new ModelViewModel(m)).ToList();
            return PartialView("_List", model);
        }
    }
}
