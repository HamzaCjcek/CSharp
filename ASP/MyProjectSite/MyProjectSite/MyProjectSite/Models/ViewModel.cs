using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProjectSite.Models;

namespace MyProjectSite.Models
{
    public class ViewModel
    {
        public IEnumerable<PopülerOyun> popülergame { get; set; }
        public IEnumerable<Oyunlar>oyunlar { get; set; }
        public IEnumerable<Sunucu> sunucu { get; set; }
    }
}