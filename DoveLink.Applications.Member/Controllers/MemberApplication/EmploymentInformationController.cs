using Microsoft.AspNetCore.Mvc;

namespace DoveLink.Applications.Member.Controllers.MemberApplication
{
    [Route("Membership/EmploymentInformation/{action}")]
    public class EmploymentInformationController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Employment Information";

            return View();
        }
    }
}