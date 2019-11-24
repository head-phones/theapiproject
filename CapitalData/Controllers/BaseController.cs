using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Utilites;
using CapitalData.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.Controllers
{
    public class BaseController : Controller
    {
        private static readonly string APIWebEndpoint = ConfigurationManager.GetConfiguration("APIWebEndpoint");
        protected static readonly string DefaultCongress = ConfigurationManager.GetConfiguration("DefaultCongress");
        protected static readonly string DefaultChamber = ConfigurationManager.GetConfiguration("DefaultChamber");
        protected readonly APIClient client = new APIClient(APIWebEndpoint); 
    }
}