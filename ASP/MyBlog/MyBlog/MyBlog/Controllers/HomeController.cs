using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        MyProfileEntities myProfile = new MyProfileEntities();
        ViewModel view = new ViewModel();
        public ActionResult Index()
        {
            view.profil=myProfile.Tbl_Profil.ToList();
            view.skills=myProfile.Tbl_Skills.ToList();
            view.media = myProfile.Tbl_Sosyalmedya.ToList();

            return View(view);
        }
        public PartialViewResult Footer()
        {
            return PartialView(view);
        }


    }
} 