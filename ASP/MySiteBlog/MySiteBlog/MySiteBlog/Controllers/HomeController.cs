using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MySiteBlog.Models;

namespace MySiteBlog.Controllers
{
    
    public class HomeController : Controller
    {
        MyProfileEntities myProfileEntities=new MyProfileEntities();
        ViewModel viewModel=new ViewModel();
        public ActionResult Index()
        {
            viewModel.profil = myProfileEntities.Tbl_Profil.ToList();
            viewModel.skills = myProfileEntities.Tbl_Skills.ToList();
            viewModel.sosyalmedya = myProfileEntities.Tbl_Sosyalmedya.ToList();
            return View(viewModel);
        }
        public PartialViewResult Footer()
        {
            return PartialView();
        }

    }
}