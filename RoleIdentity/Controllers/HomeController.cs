using RoleIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoleIdentity.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
           ApplicationDbContext context = new ApplicationDbContext();
            ViewBag.Name = new SelectList(context.Roles.Where(u => !u.Name.Contains("Admin"))
                                            .ToList(), "Name", "Name");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}