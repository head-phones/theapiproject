using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Utilites;
using APILibrary.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace APIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongressController : ControllerBase
    {
        private readonly string Endpoint = ConfigurationManager.GetConfiguration("ProPublicEndpoint");
        private readonly string Token = ConfigurationManager.GetConfiguration("ProPublicaAPIKey");

        [HttpGet]
        public ActionResult Get()
        {
            return NotFound();
        }

        [HttpGet]
        [Route("{congress}/{chamber}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.ListMembers.Response>> GetMembers(string congress, string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.ListMembers.Response>($"{congress}/{chamber}/members.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/{memberId}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.GetMember.Response>> GetMember(string memberId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.GetMember.Response>($"members/{memberId}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/new")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.NewMembers.Response>> GetNewMembers()
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.NewMembers.Response>($"members/new.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/current/{chamber}/{state}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.CurrentMembers.Response>> GetCurrentSenateMembers(string chamber, string state)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.CurrentMembers.Response>($"members/{chamber}/{state}/current.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/current/{chamber}/{state}/{district}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.CurrentMembers.Response>> GetCurrentHouseMembers(string chamber, string state, string district)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.CurrentMembers.Response>($"members/{chamber}/{state}/{district}/current.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/leaving/{congress}/{chamber}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.MembersLeaving.Response>> GetMembersLeaving(string congress, string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.MembersLeaving.Response>($"{congress}/{chamber}/members/leaving.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/votes/{memberId}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.MemberVotes.Response>> GetMemberVotes(string memberId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.MemberVotes.Response>($"members/{memberId}/votes.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/comparevotes/{firstMemberId}/{secondMemberId}/{congress}/{chamber}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.CompareVotePositions.Response>> CompareVotePositions(string firstMemberId, string secondMemberId, string congress,string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.CompareVotePositions.Response>($"members/{firstMemberId}/votes/{secondMemberId}/{congress}/{chamber}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/comparebills/{firstMemberId}/{secondMemberId}/{congress}/{chamber}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.CompareBillSponsorships.Response>> CompareBillSponsorships(string firstMemberId, string secondMemberId, string congress, string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.CompareBillSponsorships.Response>($"members/{firstMemberId}/bills/{secondMemberId}/{congress}/{chamber}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/bills/{memberId}/{type}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.CosponsoredBills.Response>> GetMemberBillsByType(string memberId, string type)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.CosponsoredBills.Response>($"members/{memberId}/bills/{type}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/office_expenses/{memberId}/{year}/{quarter}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.OfficeExpenses.Response>> GetOfficeExpenses(string memberId, string year, string quarter)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.OfficeExpenses.Response>($"members/{memberId}/office_expenses/{year}/{quarter}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/office_expenses/{memberId}/category/{category}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.MemberOfficeExpensesByCategory.Response>> GetMemberOfficeExpensesByCategory(string memberId, string category)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.MemberOfficeExpensesByCategory.Response>($"members/{memberId}/office_expenses/category/{category}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/office_expenses/category/{category}/{year}/{quarter}")]
        public async Task<ActionResult<APILibrary.ProPublica.Members.OfficeExpensesByCategory.Response>> GetOfficeExpensesByCategory(string category, string year, string quarter)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Members.OfficeExpensesByCategory.Response>($"office_expenses/category/{category}/{year}/{quarter}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("bills/{query}")]
        public async Task<ActionResult<APILibrary.ProPublica.Bills.SearchBills.Response>> SearchBills(string query)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Bills.SearchBills.Response>($"bills/search.json?query={query}");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/{chamber}/bills/{type}")]
        public async Task<ActionResult<APILibrary.ProPublica.Bills.RecentBills.Response>> GetRecentBills(string congress, string chamber, string type)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Bills.RecentBills.Response>($"{congress}/{chamber}/bills/{type}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("bills/subject/{subject}")]
        public async Task<ActionResult<APILibrary.ProPublica.Bills.RecentBillsBySubject.Response>> GetRecentBillsBySubject(string subject)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Bills.RecentBillsBySubject.Response>($"bills/subjects/{subject}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("bills/upcoming/{chamber}")]
        public async Task<ActionResult<APILibrary.ProPublica.Bills.UpcomingBills.Response>> GetUpcomingBills(string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Bills.UpcomingBills.Response>($"bills/upcoming/{chamber}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}")]
        public async Task<ActionResult<APILibrary.ProPublica.Bills.GetBill.Response>> GetBill(string congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Bills.GetBill.Response>($"{congress}/bills/{billId}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}/amendments")]
        public async Task<ActionResult<APILibrary.ProPublica.Bills.GetBillAmendments.Response>> GetBillAmendments(string congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Bills.GetBillAmendments.Response>($"{congress}/bills/{billId}/amendments.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}/subjects")]
        public async Task<ActionResult<APILibrary.ProPublica.Bills.GetBillSubjects.Response>> GetBillSubjects(string congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Bills.GetBillSubjects.Response>($"{congress}/bills/{billId}/subjects.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}/related")]
        public async Task<ActionResult<APILibrary.ProPublica.Bills.GetRelatedBills.Response>> GetRelatedBills(string congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Bills.GetRelatedBills.Response>($"{congress}/bills/{billId}/related.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("bills/subject/{query}")]
        public async Task<ActionResult<APILibrary.ProPublica.Bills.GetBillsBySubject.Response>> GetBillsBySubject(string query)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Bills.GetBillsBySubject.Response>($"bills/subjects/search.json?query={query}");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}/cosponsors")]
        public async Task<ActionResult<APILibrary.ProPublica.Bills.GetBillCosponsors.Response>> GetBillCosponsors(string congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<APILibrary.ProPublica.Bills.GetBillCosponsors.Response>($"{congress}/bills/{billId}/cosponsors.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}