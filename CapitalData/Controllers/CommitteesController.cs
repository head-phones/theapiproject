using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.ProPublica;
using APILibrary.ProPublica.Committee;
using AutoMapper;
using CapitalData.Models;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.Controllers
{
    public class CommitteesController : BaseController
    {
        public CommitteesController(IMapper mapper) : base(mapper) { }
        public IActionResult Index(string congress, string chamber)
        {
            congress = !string.IsNullOrEmpty(congress) ? congress : DefaultCongress;
            chamber = !string.IsNullOrEmpty(chamber) ? chamber : SenateChamber;
            ViewData["congress"] = congress;
            ViewData["chamber"] = chamber;
            return View();
        }
        public IActionResult List(string congress, string chamber)
        {
            ViewData["congress"] = congress;
            ViewData["chamber"] = chamber;
            var response = client.Get<Response<IEnumerable<CommitteeListResult>>>($"congress/{congress}/{chamber}/committees");
            var committees = response.results.Select(m => m.committees).FirstOrDefault();
            var model = _mapper.Map<List<CommitteeViewModel>>(committees);
            return PartialView("_List", model);
        }
        public IActionResult Details(string id, string congress, string chamber)
        {
            ViewData["congress"] = congress;
            ViewData["chamber"] = chamber;
            var response = client.Get<Response<IEnumerable<CommitteeResult>>>($"congress/{congress}/{chamber}/committees/{id}");
            var committe = response.results.FirstOrDefault();
            var model = _mapper.Map<CommitteeViewModel>(committe);
            return View(model);
        }
    }
}