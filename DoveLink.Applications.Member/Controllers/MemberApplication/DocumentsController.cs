using Microsoft.AspNetCore.Mvc;

namespace DoveLink.Applications.Member.Controllers.MemberApplication
{
    [Route("Membership/Documents/{action}")]
    public class DocumentsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Documents";

            return View();
        }
    }
}