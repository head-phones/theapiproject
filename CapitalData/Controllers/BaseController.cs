using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Utilites;
using AutoMapper;
using CapitalData.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IMapper _mapper;
        private static readonly string APIWebEndpoint = ConfigurationManager.GetConfiguration("APIWebEndpoint");
        protected static readonly string DefaultCongress = ConfigurationManager.GetConfiguration("DefaultCongress");
        protected static readonly string SenateChamber = ConfigurationManager.GetConfiguration("SenateChamber");
        protected static readonly string HouseChamber = ConfigurationManager.GetConfiguration("HouseChamber");
        protected readonly APIClient client;
        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
            client = new APIClient(APIWebEndpoint);
        }
    }
}