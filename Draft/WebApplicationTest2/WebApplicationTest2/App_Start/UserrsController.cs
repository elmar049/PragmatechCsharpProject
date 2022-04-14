using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationTest2.Models;

namespace WebApplicationTest2.App_Start
{
    public class UserrsController : Controller
    {
        private TestUserEntities db = new TestUserEntities();

        // GET: Userrs
        public ActionResult Index()
        {
            return View(db.Userr.ToList());
        }

        // GET: Userrs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userr userr = db.Userr.Find(id);
            if (userr == null)
            {
                return HttpNotFound();
            }
            return View(userr);
        }

        // GET: Userrs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Userrs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,u_name,u_surname,u_phonenumber,u_email,u_date")] Userr userr)
        {
            if (ModelState.IsValid)
            {
                db.Userr.Add(userr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userr);
        }

        // GET: Userrs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userr userr = db.Userr.Find(id);
            if (userr == null)
            {
                return HttpNotFound();
            }
            return View(userr);
        }

        // POST: Userrs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,u_name,u_surname,u_phonenumber,u_email,u_date")] Userr userr)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userr).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userr);
        }

        // GET: Userrs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userr userr = db.Userr.Find(id);
            if (userr == null)
            {
                return HttpNotFound();
            }
            return View(userr);
        }

        // POST: Userrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Userr userr = db.Userr.Find(id);
            db.Userr.Remove(userr);
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
