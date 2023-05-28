using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.Models;

namespace Music.Controllers
{
    public class HomeController : Controller
    {
        MusicEntities me=new MusicEntities();
        // GET: Home
        public ActionResult Index()
        {
            ModelView modelView = new ModelView();
            modelView.Ktg = me.Kategoriler.ToList();
            modelView.Mzk = me.Muzikler.OrderBy(x => x.MuzikİD).Take(6).ToList();
            modelView.Hkm = me.Hakkımızda.OrderBy(x => x.Hakkımdaİd).Take(6).ToList();
            return View(modelView);
        }
    }
}