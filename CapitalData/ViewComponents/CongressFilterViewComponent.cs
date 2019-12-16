using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.ViewComponents
{
    public class CongressFilterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string congress, string chamber)
        {
            ViewData["congress"] = congress;
            ViewData["chamber"] = chamber;
            return View("CongressFilter");
        }
    }
}
