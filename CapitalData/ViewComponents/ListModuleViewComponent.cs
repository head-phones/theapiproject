using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.ViewComponents
{
    public class ListModuleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string key)
        {
            ViewData["key"] = key;
            return View("ListModule");
        }
    }
}
