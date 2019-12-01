using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.ProPublica;
using APILibrary.ProPublica.Members;
using APILibrary.ProPublica.Statements;
using APILibrary.ProPublica.Votes;
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
                ViewData["memberId"] = id;
                var memberResponse = await client.GetAsync<Response<IEnumerable<Member>>>($"congress/members/{id}");
                var member = memberResponse.results.FirstOrDefault();
                var model = _mapper.Map<MemberViewModel>(member);
                return View(model);
            }
            catch(Exception e)
            {
                return StatusCode(500, e);
            }
        }

        public async Task<IActionResult> Votes(string id)
        {
            try
            {
                ViewData["memberId"] = id;
                var memberResponse = client.GetAsync<Response<IEnumerable<Member>>>($"congress/members/{id}");
                var voteResponse = client.GetAsync<Response<IEnumerable<MemberVotesResult>>>($"congress/members/{id}/votes");
                await Task.WhenAll(memberResponse, voteResponse);
                var member = memberResponse.Result.results.FirstOrDefault();
                var votes = voteResponse.Result.results.FirstOrDefault()?.votes;
                var model = new MemberVotesViewModel(_mapper.Map<List<VoteViewModel>>(votes), _mapper.Map<MemberViewModel>(member));
                return View(model);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
        public async Task<IActionResult> Bills(string id)
        {
            try
            {
                ViewData["memberId"] = id;
                var memberResponse = client.GetAsync<Response<IEnumerable<Member>>>($"congress/members/{id}");
                var billResponse = client.GetAsync<Response<IEnumerable<MemberBillsResult>>>($"congress/members/{id}/bills/introduced");
                await Task.WhenAll(memberResponse, billResponse);
                var member = memberResponse.Result.results.FirstOrDefault();
                var bills = billResponse.Result.results.FirstOrDefault()?.bills;
                var model = new MemberBillsViewModel(_mapper.Map<List<BillViewModel>>(bills), _mapper.Map<MemberViewModel>(member));
                return View(model);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
        public async Task<IActionResult> CosponsoredBills(string id)
        {
            try
            {
                ViewData["memberId"] = id;
                var memberResponse = client.GetAsync<Response<IEnumerable<Member>>>($"congress/members/{id}");
                var cosponsoredBillResponse = client.GetAsync<Response<IEnumerable<MemberBillsResult>>>($"congress/members/{id}/bills/cosponsored");
                await Task.WhenAll(memberResponse, cosponsoredBillResponse);
                var member = memberResponse.Result.results.FirstOrDefault();
                var cosponsoredBills = cosponsoredBillResponse.Result.results.FirstOrDefault()?.bills;
                var model = new MemberCosponsoredBillsViewModel(_mapper.Map<List<BillViewModel>>(cosponsoredBills), _mapper.Map<MemberViewModel>(member));
                return View(model);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
        public async Task<IActionResult> Statements(string id, string congress)
        {
            ViewData["memberId"] = id;
            var memberResponse = client.GetAsync<Response<IEnumerable<Member>>>($"congress/members/{id}");
            var statementsResponse = client.GetAsync<StatementResponse<List<Statement>>>($"congress/members/{id}/statements/{congress}");
            await Task.WhenAll(memberResponse, statementsResponse);
            var member = memberResponse.Result.results.FirstOrDefault();
            var statements = statementsResponse.Result.results;
            var model = new MemberStatementsViewModel(_mapper.Map<List<StatementViewModel>>(statements), _mapper.Map<MemberViewModel>(member));
            return View(model);
        }
        public async Task<IActionResult> Expenses(string id, int? year, int? quarter)
        {
            year = year ?? DateTime.Now.Year;
            quarter = quarter ?? GetQuarter(DateTime.Now);
            ViewData["memberId"] = id;
            ViewData["year"] = year;
            ViewData["quarter"] = quarter;
            var memberResponse = client.GetAsync<Response<IEnumerable<Member>>>($"congress/members/{id}");
            var expensesResponse = client.GetAsync<Response<IEnumerable<Expenses>>>($"congress/members/office_expenses/{id}/{year}/{quarter}");
            await Task.WhenAll(memberResponse, expensesResponse);
            var member = memberResponse.Result.results.FirstOrDefault();
            var expenses = expensesResponse.Result.results;
            var model = new MemberExpensesViewModel(_mapper.Map<List<ExpensesViewModel>>(expenses), _mapper.Map<MemberViewModel>(member));
            return View(model);
        }
        public async Task<IActionResult> Explanations(string id, string congress)
        {
            ViewData["memberId"] = id;
            var memberResponse = client.GetAsync<Response<IEnumerable<Member>>>($"congress/members/{id}");
            var explanationsResponse = client.GetAsync<Response<List<Explanation>>>($"congress/members/{id}/explanations/{congress}");
            await Task.WhenAll(memberResponse, explanationsResponse);
            var member = memberResponse.Result.results.FirstOrDefault();
            var explanations = explanationsResponse.Result.results;
            var model = new MemberExplanationsViewModel(_mapper.Map<List<ExplanationViewModel>>(explanations), _mapper.Map<MemberViewModel>(member));
            return View(model);
        }
        public static int GetQuarter(DateTime date)
        {
            if (date.Month >= 4 && date.Month <= 6)
                return 1;
            else if (date.Month >= 7 && date.Month <= 9)
                return 2;
            else if (date.Month >= 10 && date.Month <= 12)
                return 3;
            else
                return 4;
        }
    }
}