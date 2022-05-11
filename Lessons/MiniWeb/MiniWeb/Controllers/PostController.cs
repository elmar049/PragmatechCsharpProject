using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniWeb.Models;

namespace MiniWeb.Controllers
{
    
    public class PostController : Controller
    {
        BlogEntities db = new BlogEntities();
        // GET: Post
        public ActionResult Index()
        {
            ViewBag.auth = db.Author.ToList();
            ViewBag.catg = db.Category.ToList();
            return View();
        }

        
        //create () skobkanin icinde, meselcun adi BIND edende, sende modeldeki adi yox, tag Name goturursen formdakini... burda author_id post classna aitdir, ,en ise form-da ona Post Auuthor demiwem)
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "PostAuthor, PostCategory")] Post post, int PostAuthor, int PostCategory ) //sual iwaresi ne rol oynanir axi, onusz error verri
        {
           
            
            post.Author_Id = PostAuthor;
            post.Category_Id = PostCategory; ;
            //db.Post.ToList();
            


            db.Post.Add(post);
            db.SaveChanges();
            return RedirectToAction("Index");  
        }
    }
}