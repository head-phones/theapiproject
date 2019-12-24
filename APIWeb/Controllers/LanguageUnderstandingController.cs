using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.LanguageUnderstanding;
using APILibrary.Utilites;
using APILibrary.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageUnderstandingController : ControllerBase
    {
        private readonly string Endpoint = ConfigurationManager.GetConfiguration("LanguageUnderstandingEndpoint");
        private readonly string ApiKey = ConfigurationManager.GetConfiguration("LanguageUnderstandingApiKey");
        private readonly string AppKey = ConfigurationManager.GetConfiguration("LanguageUnderstandingAppKey");
        [HttpGet]
        [Route("{query}")]
        public async Task<ActionResult<Response>> Get(string query)
        {
            var client = new APIClient($"{Endpoint}/{AppKey}?timezoneOffset=-360&subscription-key={ApiKey}", ApiKey);
            try
            {
                var response = await client.GetAsync<Response>($"&q={query}");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}