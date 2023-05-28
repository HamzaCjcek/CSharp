using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        MyProfileEntities my = new MyProfileEntities();

        public ActionResult Index()
        {
            var model = my.Tbl_Skills.ToList();
            return View(model);
        }
        public ActionResult Profil()
        {
            var model = my.Tbl_Profil.ToList();
            return View(model);
        }
        public ActionResult SMedya()
        {
            var model=my.Tbl_Sosyalmedya.ToList();
            return View(model);
        }



        public ActionResult DeleteMedia(int id)
        {
            var ara = my.Tbl_Profil.Find(id);
            my.Tbl_Profil.Remove(ara);
            my.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}