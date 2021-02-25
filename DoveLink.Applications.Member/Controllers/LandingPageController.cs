using Microsoft.AspNetCore.Mvc;

namespace DoveLink.Applications.Member.Controllers
{
    public class LandingPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index_New()
        {
            return View();
        }

        public IActionResult AccountMemberSummary()
        {
            return View();
        }
    }
}
