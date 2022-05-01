using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniWeb.Models;

namespace MiniWeb.Controllers
{
    public class AuthorController : Controller
    {

        BlogEntities db = new BlogEntities();
        // GET: Model ve form-un gorsenlenmesi
        public ActionResult Index()
        {
            ViewBag.Authorss = db.Author.ToList();
            return View();
        }





        // Bu sadece Post methodu ile gelen melumati goturur databease yazir bashqa hecne
        [HttpPost]
        public ActionResult Create(Author author)
        {
            db.Author.ToList();
            db.Author.Add(author);
            db.SaveChanges();
            return RedirectToAction("Index");
        }





        public ActionResult delete(int id)   // VSEQDA SUDA NUJNO PISAT IMMENO  name tag iz FORM inputa // plus eto dopisanniy Route ot ruki, koqda pishesh adress v htmls-e to tam obezatelno dopiwi pered slovom DELETE, ewe imya controllera
        {
            Author author = db.Author.Find(id);
            db.Author.Remove(author);
            db.SaveChanges();

            return RedirectToAction("Index");
        }




        public ActionResult Update(int? id)
        {
            Author xxx=db.Author.Find(id);
            ViewBag.author= xxx;

            return View();
        }


         
        [HttpPost]

        public ActionResult Update(int id, string AuthorName)
        {
            Author xxx = db.Author.Find(id);
            xxx.AuthorName = AuthorName;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}