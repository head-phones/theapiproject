using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.ProPublica;
using APILibrary.ProPublica.Lobbying;
using AutoMapper;
using CapitalData.Models;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.Controllers
{
    public class LobbyingController : BaseController
    {
        public LobbyingController(IMapper mapper) : base(mapper) { }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> List()
        {
            var response = await client.GetAsync<Response<IEnumerable<LobbyingListResult>>>($"congress/lobbying");
            var lobbyingRepresentations = response.results.FirstOrDefault()?.lobbying_representations;
            var model = lobbyingRepresentations != null 
                ? _mapper.Map<List<LobbyingRepresentationViewModel>>(lobbyingRepresentations) 
                : new List<LobbyingRepresentationViewModel>();
            return PartialView("_List", model);
        }
    }
}