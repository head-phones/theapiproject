using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.ProPublica;
using APILibrary.ProPublica.Bills;
using APILibrary.ProPublica.Statements;
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
            var response = client.Get<Response<List<UpcomingBills>>>($"congress/bills/upcoming/{chamber}");
            var bills = response.results.Select(m => m.bills).FirstOrDefault();
            var model = _mapper.Map<List<BillViewModel>>(bills);
            return PartialView("_List", model);
        }
        public async Task<IActionResult> Details(string congress, string id)
        {
            try
            {
                var response = client.GetAsync<Response<List<Bill>>>($"congress/{congress}/bills/{id}");
                var statementsResponse = client.GetAsync<Response<List<Statement>>>($"congress/{congress}/bills/{id}/statements");
                await Task.WhenAll(response, statementsResponse);
                var bill = response.Result.results.Select(b => b).FirstOrDefault();
                var statements = statementsResponse.Result?.results;
                var model = _mapper.Map<BillViewModel>(bill);
                model.statments = _mapper.Map<List<StatementViewModel>>(statements);
                return View(model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}