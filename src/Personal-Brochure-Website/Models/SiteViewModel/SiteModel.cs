using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Brochure_Website.Models.SiteViewModel
{
    public class SiteModel
    {
        public int SiteID { get; set; }
        public string SiteName { get; set; }
        public string Copywrite { get; set; }
        public string[,] MenuItems { get; set; }
    }
}
