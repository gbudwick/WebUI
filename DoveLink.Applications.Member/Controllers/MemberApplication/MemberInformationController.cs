using DoveLink.Applications.Member.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoveLink.Applications.Member.Controllers.MemberApplication
{
    [Route("Membership/MemberInformation/{action}")]
    public class MemberInformationController : Controller
    {
        private readonly ISession session;
        public MemberInformationController(IHttpContextAccessor httpContextAccessor)
        {
            this.session = httpContextAccessor.HttpContext.Session;
        }
        public ActionResult Index()
        {
            this.session.SetString("ApplicationType", ApplicationType.Member.ToString());

            ViewBag.Title = "Prime Member Information";

            return View();
        }
    }
}