using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CapitalData.Models;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.Controllers
{
    public class BillsController : BaseController
    {
        public BillsController(IMapper mapper) : base(mapper) { }
        public IActionResult Index(string chamber)
        {
            chamber = !string.IsNullOrEmpty(chamber) ? chamber : HouseChamber;
            ViewData["chamber"] = chamber; 
            return View();
        }
        public IActionResult List(string chamber)
        {
            ViewData["chamber"] = chamber;
            var response = client.Get<APILibrary.ProPublica.Bills.UpcomingBills.Response>($"congress/bills/upcoming/{chamber}");
            var bills = response.results.Select(m => m.bills).FirstOrDefault();
            var model = _mapper.Map<List<BillViewModel>>(bills);
            return PartialView("_List", model);
        }
        public IActionResult Details(string congress, string id)
        {
            try
            {
                var response = client.Get<APILibrary.ProPublica.Bills.Bill.Response>($"congress/{congress}/bills/{id}");
                var bill = response.results.Select(b => b).FirstOrDefault();
                var model = _mapper.Map<BillViewModel>(bill);
                return View(model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}