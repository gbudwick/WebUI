using Microsoft.AspNetCore.Mvc;
using DoveLink.Applications.Member.Models;

namespace DoveLink.Applications.Member.Controllers.HomeEquity
{
    [Route("HomeEquity/LoanApplicants/{action}")]
    public class LoanApplicantsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Application Information";
            ViewBag.SubTitle = "Married applicants may apply for an individual loan/separate account.";

            return View();
        }

        public ActionResult Primary()
        {
            ViewBag.Title = "Primary Applicant";
            ViewBag.ApplicantType = LoanApplicantType.Primary;

            return View("Applicant");
        }

        public ActionResult Secondary()
        {
            ViewBag.Title = "Secondary Applicant";
            ViewBag.ApplicantType = LoanApplicantType.Secondary;

            return View("Applicant");
        }
    }
}
