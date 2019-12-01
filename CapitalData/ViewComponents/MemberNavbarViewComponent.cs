using CapitalData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.ViewComponents
{
    public class MemberNavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(MemberViewModel member)
        {
            return View("MemberNavbar", new MemberNavbarViewModel(member));
        }
    }
}
