using DoveLink.Applications.Member.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoveLink.Applications.Member.Controllers
{
    public class LoanStartController : Controller
    {
        private readonly ISession session;
        public LoanStartController(IHttpContextAccessor httpContextAccessor)
        {
            this.session = httpContextAccessor.HttpContext.Session;
        }

        [Route("LoanStart")]
        [Route("LoanStart/Index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("LoanStart/NewLoan/{loanType}")]
        public ActionResult NewLoan(string loanType)
        {
            switch (loanType.ToUpper())
            {
                case "HOMEEQUITY":
                    this.session.SetString("ApplicationType", ApplicationType.HomeEquity.ToString());
                    return Redirect("~/HomeEquity/Start/Index");
                default:
                    
                    this.session.SetString("ApplicationType", ApplicationType.Loan.ToString());
                    return Redirect("~/HomeEquity/Start/Index");
            }
        }
    }
}
