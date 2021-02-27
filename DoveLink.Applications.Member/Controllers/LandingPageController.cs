using DoveLink.Applications.Member.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DoveLink.Applications.Member.Controllers
{
    public class LandingPageController : Controller
    {
        private readonly JPEFCUDbContext _db;
        public LandingPageController(JPEFCUDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index_New()
        {
            var member = _db.Members.FirstOrDefault();
            ViewBag.ButtonText = "Begin";
            if (member != null && ValidateMember(member))
            {
                ViewBag.ButtonText = "Revisit";
            }
            else if (member != null)
            {
                ViewBag.ButtonText = "Continue";
            }
            return View("Index_New");
        }

        public bool ValidateMember(DoveLink.Applications.Member.Models.Member member)
        {
            return false;
        }
    }
}
