using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using SportSite.Models;

namespace SportSite.Controllers
{
    public class AdminController : Controller
    {
        GymEntities Adm = new GymEntities();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var model = Adm.Admin.FirstOrDefault(x => x.AdminMail == admin.AdminMail && x.AdminSifre == admin.AdminSifre); 
            if (model != null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.hata = "Kullanıcı Bilgileri Yanlış .";
            return View();
        }
        public ActionResult DetayGetir()
        {
            var model = Adm.Kategoriler.ToList();
            return View(model);
        }
    }
}