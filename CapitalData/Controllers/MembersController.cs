using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CapitalData.Models;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.Controllers
{
    public class MembersController : BaseController
    {
        public MembersController(IMapper mapper) : base(mapper) { }
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
            var response = client.Get<APILibrary.ProPublica.Members.ListMembers.Response>($"congress/{congress}/{chamber}");
            var members = response.results.Select(m => m.members).FirstOrDefault();
            var model = _mapper.Map<List<MemberViewModel>>(members);
            return PartialView("_List", model);
        }

        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var response = client.GetAsync<APILibrary.ProPublica.Members.Member.Response>($"congress/members/{id}");
                var voteResponse = client.GetAsync<APILibrary.ProPublica.Members.MemberVotes.Response>($"congress/members/votes/{id}");
                var billReponse = client.GetAsync<APILibrary.ProPublica.Members.MemberBills.Response>($"congress/members/bills/{id}/introduced");
                var cosponsoredBillReponse = client.GetAsync<APILibrary.ProPublica.Members.MemberBills.Response>($"congress/members/bills/{id}/cosponsored");
                await Task.WhenAll(response, voteResponse, billReponse, cosponsoredBillReponse);
                var votes = voteResponse.Result.results.FirstOrDefault()?.votes;
                var bills = billReponse.Result.results.FirstOrDefault()?.bills;
                var cosponsoredBills = cosponsoredBillReponse.Result.results.FirstOrDefault()?.bills;
                var member = response.Result.results.FirstOrDefault();
                var model = _mapper.Map<MemberViewModel>(member);
                model.votes = _mapper.Map<List<VoteViewModel>>(votes);
                model.bills = _mapper.Map<List<BillViewModel>>(bills);
                model.cosponsoredBills = _mapper.Map<List<BillViewModel>>(cosponsoredBills);
                return View(model);
            }
            catch(Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}