using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using MySiteBlog.Models;

namespace MySiteBlog.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        MyProfileEntities myProfileEntities = new MyProfileEntities();
        ViewModel viewModel=new ViewModel();
        public ActionResult Index()
        {
            viewModel.skills=myProfileEntities.Tbl_Skills.ToList();
            viewModel.profil = myProfileEntities.Tbl_Profil.ToList();
            viewModel.sosyalmedya = myProfileEntities.Tbl_Sosyalmedya.ToList();

            return View(viewModel);
        }

        public ActionResult DeleteSkills(int id)
        {
            var model = myProfileEntities.Tbl_Skills.Find(id);
            myProfileEntities.Tbl_Skills.Remove(model);
            myProfileEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProfil(int id)
        {
            var model = myProfileEntities.Tbl_Profil.Find(id);
            myProfileEntities.Tbl_Profil.Remove(model);
            myProfileEntities.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var model = myProfileEntities.Tbl_Skills.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Tbl_Skills s)
        {
            myProfileEntities.Entry(s).State = EntityState.Modified;
            myProfileEntities.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateProfil(int id)
        {
            var model = myProfileEntities.Tbl_Profil.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateProfil(Tbl_Profil s)
        {
            myProfileEntities.Entry(s).State = EntityState.Modified;
            myProfileEntities.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Tbl_Skills s)
        {
            myProfileEntities.Tbl_Skills.Add(s);
            myProfileEntities.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult AddProfil()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProfil(Tbl_Profil s)
        {
            myProfileEntities.Tbl_Profil.Add(s);
            myProfileEntities.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}