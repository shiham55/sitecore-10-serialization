using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreDemo.Feature.Navigation.Controllers
{
    public class MainNavigationController : Controller
    {
        public ActionResult Header()
        {
            return View("~/Views/Feature/MainNavigation/Header.cshtml");
        }

        public ActionResult Footer()
        {
            return View("~/Views/Feature/MainNavigation/Footer.cshtml");
        }
    }
}