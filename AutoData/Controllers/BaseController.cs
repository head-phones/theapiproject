using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Utilites;
using AutoData.Utilities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoData.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IMapper _mapper;
        private static readonly string APIWebEndpoint = ConfigurationManager.GetConfiguration("APIWebEndpoint");
        protected readonly APIClient client = new APIClient(APIWebEndpoint);

        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
            client = new APIClient(APIWebEndpoint);
        }
    }
}