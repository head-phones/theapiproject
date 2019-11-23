using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Utilites;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers
{
    public class APIControllerBase : ControllerBase
    {
        public ApiExtensions client { get; set; }

        public APIControllerBase(string endpoint, string token)
        {
            client = new ApiExtensions(endpoint, token);
        }
    }
}