using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectSite.Models;

namespace MyProjectSite.Controllers
{
    public class HomeController : Controller
    {
        GameEntities gameEntities=new GameEntities();
        ViewModel ViewModel=new ViewModel();
        public ActionResult Index()
        {
            ViewModel.popülergame=gameEntities.PopülerOyun.ToList();
            ViewModel.oyunlar = gameEntities.Oyunlar.ToList();
            ViewModel.sunucu=gameEntities.Sunucu.ToList();
            return View(ViewModel);
        }
        public PartialViewResult Footer()
        { return PartialView(); }
    }
}