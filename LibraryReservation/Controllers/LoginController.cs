using Application.Features.Rooms.Queries.GetById;
using Application.Features.Users.Queries.GetById;
using Application.Features.Users.Queries.GetByUserName;
using Domain.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LibraryReservation.Controllers
{
    public class LoginController : BaseController
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(User user)
        {
            GetByUserNameUserQuery getByUserNameUserQuery = new() { UserName = user.UserName, Password = user.Password };
            GetByUserNameUserResponse response = await Mediator.Send(getByUserNameUserQuery);

            if (response != null)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, response.UserName),
                    new Claim(ClaimTypes.NameIdentifier, response.Id.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
