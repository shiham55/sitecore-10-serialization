using System.Web.Mvc;

namespace SitecoreDemo.Feature.HomePage.Controllers
{
    public class WidgetsController : Controller
    {
        public ActionResult Banner()
        {
            return View("~/Views/Feature/HomePage/Widgets/Banner.cshtml");
        }

        public ActionResult Destinations()
        {
            return View("~/Views/Feature/HomePage/Widgets/Destinations.cshtml");
        }

        public ActionResult FeaturedContent()
        {
            return View("~/Views/Feature/HomePage/Widgets/FeaturedContent.cshtml");
        }
    }
}