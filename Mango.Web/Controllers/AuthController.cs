using Mango.Web.Models.DTOs;
using Mango.Web.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Controllers
{
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Login()
        {
            LoginRequestDTO loginRequestDTO = new LoginRequestDTO();

            return View(loginRequestDTO);
        }

        [HttpPost]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            return View();
        }
    }
}
