using Microsoft.AspNetCore.Mvc;

namespace LibraryReservation.Controllers
{
    public class LoginController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
