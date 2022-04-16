﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WBPOSTGET.Models;


namespace WBPOSTGET.Controllers
{
    public class mainController : Controller
    {
        userlerEntities db=new userlerEntities();

        // GET: main

        public ActionResult Index()
        {
            ViewBag.Alluser = db.OneUser.ToList();

           

            return View();
        }

        [HttpPost]

        public ActionResult Index(string ad)
        {

            /*ViewBag.Alluser = db.OneUser.ToList();  */    ///bu olmasa iwlemir

            //ViewBag.name = Request.Params["adin"];
            //ViewBag.surname = Request.Params["soyad"];
            //var 2singleuser = new OneUser();
            //singleuser.username = ViewBag.name;
            //singleuser.usersurname = ViewBag.surname;
            //ViewBag.Alluser = db.OneUser.ToList();
            //db.OneUser.Add(singleuser);
            //db.SaveChanges();                       //pcmu ne zdes

            return View();
        }



        public ActionResult Listname()
        {
            ViewBag.name = Request.Params["adin"];
            ViewBag.surname = Request.Params["soyad"];

            var singleuser = new OneUser();
            singleuser.username = ViewBag.name;
            singleuser.usersurname = ViewBag.surname;           
            db.OneUser.Add(singleuser);
            db.SaveChanges();
            ViewBag.Alluser = db.OneUser.ToList();
            return View();
        }
       
       public ActionResult delete()
        {
            var id=Request.Params["id"];
            var x= db.OneUser.Find(Convert.ToInt32(id));
            db.OneUser.Remove(x);
            db.SaveChanges();
            return RedirectToAction("Listname");
        }

    }
}