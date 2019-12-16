using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.ViewComponents
{
    public class ChamberFilterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string congress = null, string chamber = null)
        {
            ViewData["congress"] = congress ?? string.Empty;
            ViewData["chamber"] = chamber ?? string.Empty;
            return View("ChamberFilter");
        }
    }
}
