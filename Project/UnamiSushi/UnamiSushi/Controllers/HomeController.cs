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
        
        //Partial View Test
        //public ActionResult Partial()
        //{
        //    return View();
        //}
        public ActionResult Menu()
        {
            return View(db.MenuCategories.ToList());
        }

        public ActionResult SushidoPV()
        {
            MenuViewModel menuVM = new MenuViewModel();
            // query a category
            var aCategory = (from c in db.MenuCategories
                             where c.CategoryName == "Sushi Burrito"
                             select c).FirstOrDefault<MenuCategory>();
            var resultCategory = aCategory.CategoryName.ToString();

            menuVM.CategoryName = resultCategory;// populating the data into burritoVM
            foreach (var item in resultCategory)
            {
                var menuItems = (from m in db.MenuItems
                                 where m.CategoryName == "Sushi Burrito"
                                 select m.MenuItemName).ToList();
                menuVM.MenuItemName = menuItems;
            }

            List<MenuViewModel> viewModelList = new List<MenuViewModel>();
            viewModelList.Add(menuVM);

            return View(viewModelList);
        }

        public ActionResult SushiRollsPV()
        {
            return View();
        }
        public ActionResult AppetizersPV()
        {
            return View();
        }
        public ActionResult AsianGrillPV()
        {
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