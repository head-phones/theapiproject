using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.ProPublica;
using APILibrary.ProPublica.Bills;
using APILibrary.ProPublica.Members;
using APILibrary.ProPublica.Statements;
using APILibrary.ProPublica.Votes;
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
        public async Task<ActionResult<Response<IEnumerable<MemberListResult>>>> GetMembers(string congress, string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<IEnumerable<MemberListResult>>>($"{congress}/{chamber}/members.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/{memberId}")]
        public async Task<ActionResult<Response<List<Member>>>> GetMember(string memberId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<Member>>>($"members/{memberId}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/new")]
        public async Task<ActionResult<Response<List<MemberListResult>>>> GetNewMembers()
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<MemberListResult>>>($"members/new.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/current/{chamber}/{state}")]
        public async Task<ActionResult<Response<IEnumerable<MemberListItem>>>> GetCurrentSenateMembers(string chamber, string state)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<IEnumerable<MemberListItem>>>($"members/{chamber}/{state}/current.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/current/{chamber}/{state}/{district}")]
        public async Task<ActionResult<Response<IEnumerable<MemberListItem>>>> GetCurrentHouseMembers(string chamber, string state, string district)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<IEnumerable<MemberListItem>>> ($"members/{chamber}/{state}/{district}/current.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/leaving/{congress}/{chamber}")]
        public async Task<ActionResult<Response<List<MemberListResult>>>> GetMembersLeaving(string congress, string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<MemberListResult>>>($"{congress}/{chamber}/members/leaving.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/{memberId}/votes")]
        public async Task<ActionResult<Response<IEnumerable<MemberVotesResult>>>> GetMemberVotes(string memberId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<IEnumerable<MemberVotesResult>>>($"members/{memberId}/votes.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/comparevotes/{firstMemberId}/{secondMemberId}/{congress}/{chamber}")]
        public async Task<ActionResult<Response<IEnumerable<CompareVotePositionsResult>>>> CompareVotePositions(string firstMemberId, string secondMemberId, string congress,string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<IEnumerable<CompareVotePositionsResult>>>($"members/{firstMemberId}/votes/{secondMemberId}/{congress}/{chamber}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/comparebills/{firstMemberId}/{secondMemberId}/{congress}/{chamber}")]
        public async Task<ActionResult<Response<IEnumerable<CompareBillSponsorshipsResult>>>> CompareBillSponsorships(string firstMemberId, string secondMemberId, string congress, string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<IEnumerable<CompareBillSponsorshipsResult>>>($"members/{firstMemberId}/bills/{secondMemberId}/{congress}/{chamber}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/{memberId}/bills/{type}")]
        public async Task<ActionResult<Response<IEnumerable<MemberBillsResult>>>> GetMemberBillsByType(string memberId, string type)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<IEnumerable<MemberBillsResult>>>($"members/{memberId}/bills/{type}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/office_expenses/{memberId}/{year}/{quarter}")]
        public async Task<ActionResult<Response<List<Expenses>>>> GetOfficeExpenses(string memberId, string year, string quarter)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<Expenses>>>($"members/{memberId}/office_expenses/{year}/{quarter}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/office_expenses/{memberId}/category/{category}")]
        public async Task<ActionResult<Response<List<Expenses>>>> GetMemberOfficeExpensesByCategory(string memberId, string category)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<Expenses>>>($"members/{memberId}/office_expenses/category/{category}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/office_expenses/category/{category}/{year}/{quarter}")]
        public async Task<ActionResult<Response<List<Expenses>>>> GetOfficeExpensesByCategory(string category, string year, string quarter)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<Expenses>>>($"office_expenses/category/{category}/{year}/{quarter}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("bills/{query}")]
        public async Task<ActionResult<BillsResponse<List<SearchBills>>>> SearchBills(string query)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<BillsResponse<List<SearchBills>>>($"bills/search.json?query={query}");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/{chamber}/bills/{type}")]
        public async Task<ActionResult<Response<List<Bill>>>> GetRecentBills(string congress, string chamber, string type)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<Bill>>>($"{congress}/{chamber}/bills/{type}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("bills/subject/{subject}")]
        public async Task<ActionResult<BillsResponse<List<Bill>>>> GetRecentBillsBySubject(string subject)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<BillsResponse<List<Bill>>>($"bills/subjects/{subject}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("bills/upcoming/{chamber}")]
        public async Task<ActionResult<BillsResponse<List<UpcomingBills>>>> GetUpcomingBills(string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<BillsResponse<List<UpcomingBills>>>($"bills/upcoming/{chamber}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}")]
        public async Task<ActionResult<BillsResponse<List<Bill>>>> GetBill(string congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<BillsResponse<List<Bill>>>($"{congress}/bills/{billId}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}/amendments")]
        public async Task<ActionResult<Response<List<BillAmendments>>>> GetBillAmendments(string congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<BillAmendments>>>($"{congress}/bills/{billId}/amendments.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}/subjects")]
        public async Task<ActionResult<Response<List<Bill>>>> GetBillSubjects(string congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<Bill>>>($"{congress}/bills/{billId}/subjects.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}/related")]
        public async Task<ActionResult<BillsResponse<List<Bill>>>> GetRelatedBills(string congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<BillsResponse<List<Bill>>>($"{congress}/bills/{billId}/related.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("bills/subject/{query}")]
        public async Task<ActionResult<Response<List<BillSubjects>>>> GetBillsBySubject(string query)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<BillSubjects>>>($"bills/subjects/search.json?query={query}");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}/cosponsors")]
        public async Task<ActionResult<Response<List<BillCosponsors>>>> GetBillCosponsors(string congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<BillCosponsors>>>($"{congress}/bills/{billId}/cosponsors.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{chamber}/votes/recent")]
        public async Task<ActionResult<Response<RecentVotesResult>>> GetRecentVotes(string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<RecentVotesResult>>($"{chamber}/votes/recent.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/{chamber}/votes/{voteType}")]
        public async Task<ActionResult<Response<List<VotesByTypeResult>>>> GetVotesByType(string congress, string chamber, string voteType)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<VotesByTypeResult>>>($"{congress}/{chamber}/votes/{voteType}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{chamber}/votes/{year}/{month}")]
        public async Task<ActionResult<Response<VotesByDateResult>>> GetVotesByDate(string chamber, string year, string month)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<VotesByDateResult>>($"{chamber}/votes/{year}/{month}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{chamber}/votes/range/{startDate}/{endDate}")]
        public async Task<ActionResult<Response<VotesByDateResult>>> GetVotesByRange(string chamber, string startDate, string endDate)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<VotesByDateResult>>($"{chamber}/votes/{startDate}/{endDate}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/nominations")]
        public async Task<ActionResult<Response<SenateNominationVotesResult>>> GetSenateNominationVotes(string congress)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<SenateNominationVotesResult>>($"{congress}/nominations.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/explanations")]
        public async Task<ActionResult<Response<List<Explanation>>>> GetRecentExplanations(string congress)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<Explanation>>>($"{congress}/explanations.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/explanations/votes")]
        public async Task<ActionResult<Response<List<Explanation>>>> GetRecentExplanationVotes(string congress)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<Explanation>>>($"{congress}/explanations/votes.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/explanations/votes/{category}")]
        public async Task<ActionResult<Response<List<Explanation>>>> GetRecentExplanationVotesByCategory(string congress, string category)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<List<Explanation>>>($"{congress}/explanations/votes/{category}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/{memberId}/explanations/{congress}")]
        public async Task<ActionResult<ExplanationsResponse<IEnumerable<Explanation>>>> GetRecentMemberExplanations(string memberId, string congress)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<ExplanationsResponse<IEnumerable<Explanation>>>($"members/{memberId}/explanations/{congress}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/{memberId}/explanations/{congress}/votes")]
        public async Task<ActionResult<ExplanationsResponse<IEnumerable<Explanation>>>> GetRecentMemberExplanationVotes(string memberId, string congress)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<ExplanationsResponse<IEnumerable<Explanation>>>($"members/{memberId}/explanations/{congress}/votes.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/{memberId}/explanations/{congress}/votes/{category}")]
        public async Task<ActionResult<ExplanationsResponse<IEnumerable<Explanation>>>> GetRecentMemberExplanationVotesByCategory(string memberId, string congress, string category)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<ExplanationsResponse<IEnumerable<Explanation>>>($"members/{memberId}/explanations/{congress}/votes/{category}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/{chamber}/sessions/{sessionNumber}/votes/{rollCallNumber}")]
        public async Task<ActionResult<Response<RollCallVoteResult>>> GetRoleCallVote(string congress, string chamber, string sessionNumber, string rollCallNumber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response<RollCallVoteResult>>($"{congress}/{chamber}/sessions/{sessionNumber}/votes/{rollCallNumber}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("statements")]
        public async Task<ActionResult<StatementResponse<List<Statement>>>> GetRecentStatements()
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Statement>>>($"/statements/latest.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("statements/date/{date}")]
        public async Task<ActionResult<StatementResponse<List<Statement>>>> GetStatementsByDate(string date)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Statement>>>($"/statements/date/{date}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("statements/search/{term}")]
        public async Task<ActionResult<StatementResponse<List<Statement>>>> SearchStatements(string term)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Statement>>>($"/statements/search.json?query={term}");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("statements/subjects")]
        public async Task<ActionResult<StatementResponse<List<Subject>>>> GetStatementSubjects()
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Subject>>>($"/statements/subjects.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("statements/subject/{subject}")]
        public async Task<ActionResult<StatementResponse<List<Statement>>>> GetStatementsBySubject(string subject)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Statement>>>($"/statements/subject/{subject}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("members/{memberId}/statements/{congress}")]
        public async Task<ActionResult<StatementResponse<List<Statement>>>> GetStatementsByMember(string memberId, int congress)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Statement>>>($"/members/{memberId}/statements/{congress}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("{congress}/bills/{billId}/statements")]
        public async Task<ActionResult<StatementResponse<List<Statement>>>> GetStatementsByBill(int congress, string billId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Statement>>>($"{congress}/bills/{billId}/statements");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("statements/committees")]
        public async Task<ActionResult<StatementResponse<List<Statement>>>> GetRecentCommitteeStatements()
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Statement>>>($"statements/committees/latest.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("statements/committees/date/{date}")]
        public async Task<ActionResult<StatementResponse<List<Statement>>>> GetCommitteeStatementsByDate(string date)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Statement>>>($"statements/committees/date/{date}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("statements/committees/{committeeId}")]
        public async Task<ActionResult<StatementResponse<List<Statement>>>> GetCommitteeStatementsByCommittee(string committeeId)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Statement>>>($"statements/committees/{committeeId}.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet]
        [Route("statements/committees/search/{term}")]
        public async Task<ActionResult<StatementResponse<List<Statement>>>> SearchCommitteeStatements(string term)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<StatementResponse<List<Statement>>>($"statements/committees/search.json?query={term}");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}