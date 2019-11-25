using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CapitalData.Models;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.Controllers
{
    public class VotesController : BaseController
    {
        public VotesController(IMapper _mapper) : base(_mapper) { }
        public IActionResult Index(string chamber)
        {
            chamber = !string.IsNullOrEmpty(chamber) ? chamber : HouseChamber;
            ViewData["chamber"] = chamber;
            return View();
        }
        public IActionResult List(string chamber)
        {
            ViewData["chamber"] = chamber;
            var response = client.Get<APILibrary.ProPublica.Votes.RecentVotes.Response>($"congress/{chamber}/votes/recent");
            var votes = response.results.votes;
            var model = _mapper.Map<List<VoteViewModel>>(votes);
            return PartialView("_List", model);
        }
    }
}