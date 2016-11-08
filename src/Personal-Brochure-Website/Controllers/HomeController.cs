using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Personal_Brochure_Website.Models.ProfileModelView;
using Personal_Brochure_Website.Models.SiteViewModel;

namespace Personal_Brochure_Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Get Site Details
            var site = new SiteModel
            {
                SiteName = "Lorin Hart",
                Copywrite = "Official Site of Lorin M Hart",
                MenuItems = new string[,] { { "Home", "/index" }, { "Contact", "/contact" } }

        };

            //Get Profile from datasource
            var Profile = new ProfileModel
            {
                FirstName = "Lorin",
                LastName = "Hart",
                Email = "l.mark.hart@gmail.com",
                BioDetails = DemoFill.FillWithLatinText(500),
                BioImagePath = "images/biopic.jpg",
                SiteName = site.SiteName,
                Copywrite = site.Copywrite,
                Menu = site.MenuItems
            };

            return View(Profile);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
