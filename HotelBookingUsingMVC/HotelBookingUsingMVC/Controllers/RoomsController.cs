using HotelBookingUsingMVC.Database;
using System.Linq;
using System.Web.Mvc;

namespace HotelBookingUsingMVC.Controllers
{
    public class RoomsController : Controller
    {
        private HotelManagementSystemEntities5 db = new HotelManagementSystemEntities5();
        // GET: Rooms
        [HttpGet]
        public ActionResult SelectRoomByHotelCode(string hotelcode)
        {
            Session["HotelCode"] = hotelcode;
            var rooms = db.Rooms.Where(r => r.HotelCode == hotelcode && r.RoomStatus == "Available").ToList();
            return View(rooms);
        }

      
        public ActionResult SelectRoom(int roomId)
        {
            Session["RoomId"] = roomId;
            return RedirectToAction("SelectAmenities", "Amenities");
        }
    }
}