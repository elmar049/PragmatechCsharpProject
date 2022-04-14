using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationTest2.Models;

namespace WebApplicationTest2.Controllers
{
    public class ShortInfoesController : Controller
    {
        private TestUserEntities db = new TestUserEntities();

        // GET: ShortInfoes
        public ActionResult Index()
        {
            return View(db.ShortInfo.ToList());
        }

        // GET: ShortInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShortInfo shortInfo = db.ShortInfo.Find(id);
            if (shortInfo == null)
            {
                return HttpNotFound();
            }
            return View(shortInfo);
        }

        // GET: ShortInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShortInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,u_HairColour,u_Height,u_Weight")] ShortInfo shortInfo)
        {
            if (ModelState.IsValid)
            {
                db.ShortInfo.Add(shortInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shortInfo);
        }

        // GET: ShortInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShortInfo shortInfo = db.ShortInfo.Find(id);
            if (shortInfo == null)
            {
                return HttpNotFound();
            }
            return View(shortInfo);
        }

        // POST: ShortInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,u_HairColour,u_Height,u_Weight")] ShortInfo shortInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shortInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shortInfo);
        }

        // GET: ShortInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShortInfo shortInfo = db.ShortInfo.Find(id);
            if (shortInfo == null)
            {
                return HttpNotFound();
            }
            return View(shortInfo);
        }

        // POST: ShortInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShortInfo shortInfo = db.ShortInfo.Find(id);
            db.ShortInfo.Remove(shortInfo);
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
