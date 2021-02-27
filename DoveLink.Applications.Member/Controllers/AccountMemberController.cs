using DoveLink.Applications.Member.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoveLink.Applications.Member.Controllers
{
    public class AccountMemberController : Controller
    {
        private readonly JPEFCUDbContext _db;
        public AccountMemberController(JPEFCUDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var members = _db.Members
                          .Include(m => m.Address)
                          .ToList();
            return View(members);
        }

        public IActionResult AddMembers()
        {
            var member = new DoveLink.Applications.Member.Models.Member();
            if (!_db.Members.Any(m => m.IsPrimaryAccountHolder.Value))
                member.IsPrimaryAccountHolder = true;
            return View(member);
        }
    }
}
