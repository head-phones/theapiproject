using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoData.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoData.Controllers
{
    public class DecodeVINController : BaseController
    {
        public DecodeVINController(IMapper mapper) : base(mapper) { }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string vin, string year)
        {
            var response = client.Get<APILibrary.Vehicle.DecodeVIN.Response>($"vehicle/DecodeVIN/{vin}/{year}");
            var results = response.Results;
            var model = _mapper.Map<List<DecodeVINViewModel>>(results);
            return PartialView("_List", model);
        }
    }
}