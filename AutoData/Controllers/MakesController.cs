using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoData.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoData.Controllers
{
    public class MakesController : BaseController
    {
        public MakesController(IMapper mapper) : base(mapper) { }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var response = client.Get<APILibrary.Vehicle.AllMakes.Response>($"vehicle/GetAllMakes");
            var makes = response.Results;
            var model = _mapper.Map<List<MakeViewModel>>(makes);
            return PartialView("_List", model);
        }
    }
}