using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Utilites;
using AutoData.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace AutoData.Controllers
{
    public class BaseController : Controller
    {
        private static readonly string APIWebEndpoint = ConfigurationManager.GetConfiguration("APIWebEndpoint");
        protected readonly APIClient client = new APIClient(APIWebEndpoint); 
    }
}