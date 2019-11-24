using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapitalData.Models;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.Controllers
{
    public class MembersController : BaseController
    {
        public IActionResult Index(string congress, string chamber)
        {
            congress = !string.IsNullOrEmpty(congress) ? congress : DefaultCongress;
            chamber = !string.IsNullOrEmpty(chamber) ? chamber : DefaultChamber;
            ViewData["congress"] = congress;
            ViewData["chamber"] = chamber;
            return View();
        }
        public IActionResult List(string congress, string chamber)
        {
            ViewData["congress"] = congress;
            ViewData["chamber"] = chamber;
            var response = client.Get<APILibrary.ProPublica.Members.ListMembers.Response>($"congress/{congress}/{chamber}");
            var model = new List<MemberViewModel>();
            var members = response.results.Select(m => m.members).FirstOrDefault();
            model = members?.Select(m => new MemberViewModel(m)).ToList();
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
                var member = response.Result.results.FirstOrDefault();
                var model = new MemberViewModel(member, 
                    voteResponse.Result.results.Select(v => v.votes).FirstOrDefault().ToList(),
                    billReponse.Result.results.Select(b => b.bills).FirstOrDefault().ToList(),
                    cosponsoredBillReponse.Result.results.Select(b => b.bills).FirstOrDefault().ToList());
                return View(model);
            }
            catch(Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}