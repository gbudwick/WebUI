using Microsoft.AspNetCore.Mvc;

namespace DoveLink.Applications.Member.Controllers.MemberApplication
{
    [Route("Membership/DecisionOptions/{action}")]
    public class DecisionOptionsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Decision Options";

            return View();
        }
    }
}
