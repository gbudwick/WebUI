using Microsoft.AspNetCore.Mvc;

namespace DoveLink.Applications.Member.Controllers.HomeEquity
{
    [Route("HomeEquity/Start/{action}")]
    public class HomeEquityApplicationController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Equity Loan Application";
            ViewBag.SubTitle = "Married applicants may apply for an individual loan/separate account.";

            return View();
        }
    }
}
