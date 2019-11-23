using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Utilites;
using APILibrary.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APILibrary.ProPublica.Members.ListMembers;

namespace APIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongressController : ControllerBase
    {
        private string Endpoint = ConfigurationManager.GetConfiguration("ProPublicEndpoint");
        private string Token = ConfigurationManager.GetConfiguration("ProPublicaAPIKey");

        [HttpGet]
        public ActionResult Get()
        {
            return NotFound();
        }

        [HttpGet]
        [Route("{congress}/{chamber}")]
        public async Task<ActionResult<Response>> GetMembers(string congress, string chamber)
        {
            var client = new APIClient(Endpoint, Token);
            try
            {
                var response = await client.GetAsync<Response>($"{congress}/{chamber}/members.json");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}