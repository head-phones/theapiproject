using AutoData.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoData.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Footer", new FooterViewModel());
        }
    }
}
