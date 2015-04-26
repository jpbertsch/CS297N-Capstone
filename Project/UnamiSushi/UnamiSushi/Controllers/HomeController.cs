using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnamiSushi.DAL;
using UnamiSushi.Models;

namespace UnamiSushi.Controllers
{
    public class HomeController : Controller
    {
        private PrimaryContext db = new PrimaryContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Partial()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View(db.MenuCategories.ToList());
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