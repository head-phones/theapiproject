using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoData.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoData.Controllers
{
    public class MakesController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var response = client.Get<APILibrary.Vehicle.AllMakes.Response>($"vehicle/GetAllMakes");
            var model = new List<MakeViewModel>();
            var makes = response.Results;
            model = makes?.Select(m => new MakeViewModel(m)).ToList();
            return PartialView("_List", model);
        }
    }
}