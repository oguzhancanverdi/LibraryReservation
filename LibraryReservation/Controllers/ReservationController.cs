using Microsoft.AspNetCore.Mvc;

namespace LibraryReservation.Controllers
{
    public class ReservationController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
