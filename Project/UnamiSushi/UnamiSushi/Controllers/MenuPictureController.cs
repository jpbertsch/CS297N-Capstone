using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UnamiSushi.DAL;
using UnamiSushi.Models;

namespace UnamiSushi.Controllers
{
    public class MenuPictureController : Controller
    {
        private PrimaryContext db = new PrimaryContext();

        // GET: MenuPicture
        public ActionResult Index()
        {
            return View(db.MenuPictures.ToList());
        }

        // GET: MenuPicture/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuPicture menuPicture = db.MenuPictures.Find(id);
            if (menuPicture == null)
            {
                return HttpNotFound();
            }
            return View(menuPicture);
        }

        // GET: MenuPicture/Create
        public ActionResult Create()
        {
            ViewBag.MenuItemID = new SelectList(db.MenuItems, "MenuItemID", "MenuItemName");

            return View();
        }

        // POST: MenuPicture/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PictureID,PictureItem,PicturePathname,ThumbnailPathname")] MenuPicture menuPicture)
        {
            if (ModelState.IsValid)
            {
                db.MenuPictures.Add(menuPicture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuPicture);
        }

        // GET: MenuPicture/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuPicture menuPicture = db.MenuPictures.Find(id);
            if (menuPicture == null)
            {
                return HttpNotFound();
            }
            return View(menuPicture);
        }

        // POST: MenuPicture/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PictureID,PictureItem,PicturePathname,ThumbnailPathname")] MenuPicture menuPicture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuPicture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menuPicture);
        }

        // GET: MenuPicture/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuPicture menuPicture = db.MenuPictures.Find(id);
            if (menuPicture == null)
            {
                return HttpNotFound();
            }
            return View(menuPicture);
        }

        // POST: MenuPicture/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuPicture menuPicture = db.MenuPictures.Find(id);
            db.MenuPictures.Remove(menuPicture);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
