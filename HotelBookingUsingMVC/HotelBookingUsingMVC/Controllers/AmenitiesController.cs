using HotelBookingUsingMVC.Database;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
namespace HotelBookingUsingMVC.Controllers
{
    public class AmenitiesController : Controller
    {
        private HotelManagementSystemEntities5 db = new HotelManagementSystemEntities5();
        // GET: Amenities
        [HttpGet]
        public ActionResult SelectAmenities()
        {

            List<Amenity> amenities = db.Amenities.ToList();
            return View(amenities);
        }
        [HttpPost]
        public ActionResult SelectAmenities(List<Amenity> amenities)
        {
            return Json(amenities, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Details(List<Amenity> amenities)
        {
            
            return Json(amenities, JsonRequestBehavior.AllowGet);// View(amenities);
        }
    }
}