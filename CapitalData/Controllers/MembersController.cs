using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.ProPublica;
using APILibrary.ProPublica.Members;
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
            var response = client.Get<Response<IEnumerable<MemberListResult>>>($"congress/{congress}/{chamber}");
            var members = response.results.Select(m => m.members).FirstOrDefault();
            var model = _mapper.Map<List<MemberViewModel>>(members);
            return PartialView("_List", model);
        }

        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var response = client.GetAsync<Response<IEnumerable<Member>>>($"congress/members/{id}");
                var voteResponse = client.GetAsync<Response<IEnumerable<MemberVotesResult>>>($"congress/members/{id}/votes");
                var billReponse = client.GetAsync<Response<IEnumerable<MemberBillsResult>>>($"congress/members/{id}/bills/introduced");
                var cosponsoredBillReponse = client.GetAsync<Response<IEnumerable<MemberBillsResult>>>($"congress/members/{id}/bills/cosponsored");
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