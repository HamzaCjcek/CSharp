using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class ModelView
    {
        public IEnumerable<Kategoriler> Ktg { get; set; }
        public IEnumerable<Muzikler> Mzk { get; set; }
        public IEnumerable<Hakkımızda> Hkm { get; set; }
    }
}