using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.ProPublica;
using APILibrary.ProPublica.Statements;
using AutoMapper;
using CapitalData.Models;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.Controllers
{
    public class StatementsController : BaseController
    {
        public StatementsController(IMapper mapper) : base(mapper) { }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> List()
        {
            var response = await client.GetAsync<StatementResponse<IEnumerable<Statement>>>($"congress/statements");
            var model = _mapper.Map<List<StatementViewModel>>(response.results);
            return PartialView("_List", model);
        }
        public async Task<IActionResult> Search(string term)
        {
            var response = await client.GetAsync<StatementResponse<IEnumerable<Statement>>>($"congress/statements/search/{term}");
            var model = _mapper.Map<List<StatementViewModel>>(response.results);
            return PartialView("_List", model);
        }
    }
}