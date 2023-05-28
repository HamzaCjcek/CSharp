using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.Models;

namespace Music.Controllers
{
    public class AdminController : Controller
    {
        MusicEntities musicEntities= new MusicEntities();
        // GET: Admin


        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            var model=musicEntities.Admin.FirstOrDefault(x => x.AdminMail == admin.AdminMail && x.AdminSifre==admin.AdminSifre);
            if (model != null)
            {
                return RedirectToAction("Index", "Admin");
            }
            ViewBag.hata = "Kullanıcı Bilgileri Yanlış .";
            return View();
        }
    }
}