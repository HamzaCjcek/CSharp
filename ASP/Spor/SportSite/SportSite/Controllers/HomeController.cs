using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportSite.Models;

namespace SportSite.Controllers
{
    public class HomeController : Controller
    {
        GymEntities gymEntities= new GymEntities();
        public ActionResult Index()
        {
            var ss = gymEntities.Kategoriler.ToList();
            return View(ss);
        }
        public ActionResult Detaylar(int id)
        {
            var model = gymEntities.Kategoriler.Where(x => x.İd == id).ToList();
            return View(model);
        }
    }
}