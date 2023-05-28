using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyBlog.Models;

namespace MyBlog.Models
{
    public class ViewModel
    {
        public IEnumerable<Tbl_Profil> profil { get; set; }
        public IEnumerable<Tbl_Skills> skills { get; set; }
        public IEnumerable<Tbl_Sosyalmedya> media { get; set; }
    }
}