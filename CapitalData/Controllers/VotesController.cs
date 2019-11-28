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
            var votes = _mapper.Map<List<VoteViewModel>>(response.results.votes);
            var labels = votes.Select(v => v.result).Distinct();
            var data = new List<int>();
            labels.ToList().ForEach(x => data.Add(votes.Count(c => c.result == x)));
            var model = new VoteListViewModel(votes, labels , data);

            return PartialView("_List", model);
        }
        public IActionResult Details(string congress, string chamber, int sessionNumber, int rollCallNumber)
        {
            var response = client.Get<APILibrary.ProPublica.Votes.RollCallVote.Response>($"congress/{congress}/{chamber}/sessions/{sessionNumber}/votes/{rollCallNumber}");
            var vote = response.results.votes.vote;
            var model = _mapper.Map<VoteViewModel>(vote);
            return View(model);
        }
    }
}