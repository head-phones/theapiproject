using CapitalData.Models;
using Microsoft.AspNetCore.Mvc;

namespace CapitalData.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Footer", new FooterViewModel());
        }
    }
}
