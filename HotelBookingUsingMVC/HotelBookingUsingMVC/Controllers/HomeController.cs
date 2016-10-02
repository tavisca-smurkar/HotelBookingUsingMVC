using HotelBookingUsingMVC.Models;
using System.Web.Mvc;

namespace HotelBookingUsingMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Search search = new Search();
            return View(search);
        }

        [HttpPost]
        public ActionResult Index(Search search)
        {
           return RedirectToAction("Index", "Hotels", new { city = search.City });
        }













        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}