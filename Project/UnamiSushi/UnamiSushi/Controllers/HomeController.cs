﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        
        public ActionResult Menu()
        {
            return View(db.MenuCategories);
        }


        public ActionResult SushidoPV()
        {
            //MenuViewModel menuVM = new MenuViewModel();
            //// query a category
            //var aCategory = (from c in db.MenuCategories
            //                 where c.CategoryName == "Sushi Burrito"
            //                 select c).FirstOrDefault<MenuCategory>();
            //var resultCategory = aCategory.CategoryName.ToString();

            //menuVM.CategoryName = resultCategory;// populating the data into burritoVM
            //foreach (var item in resultCategory)
            //{
            //    var menuItems = (from m in db.MenuItems
            //                     where m.CategoryName == "Sushi Burrito"
            //                     select m.MenuItemName).ToList();
            //    menuVM.MenuItemName = menuItems;
            //}

            //List<MenuViewModel> viewModelList = new List<MenuViewModel>();
            //viewModelList.Add(menuVM);

            return View();
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

        // GET: MenuCategory/Details/5

        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            MenuCategory menuCategory = db.MenuCategories.Find(id);
            if (menuCategory == null)
            {
                return HttpNotFound();
            }
            return View(menuCategory);
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

        [ChildActionOnly]
        public ActionResult CategoryPartialDetails(int? id)
        {
            var model = db.MenuCategories.Find(id);

            return PartialView("Details", model);
        }
    }
}