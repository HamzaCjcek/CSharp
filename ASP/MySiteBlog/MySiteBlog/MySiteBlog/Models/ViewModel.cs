using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySiteBlog.Models;

namespace MySiteBlog.Models
{
    public class ViewModel
    {
        public IEnumerable<Tbl_Skills> skills { get; set; }
        public IEnumerable<Tbl_Profil> profil { get; set; }
        public IEnumerable<Tbl_Sosyalmedya> sosyalmedya { get; set; }

    }
}