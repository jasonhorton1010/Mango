﻿using Mango.Web.Models;
using Mango.Web.Services.IService;
using Mango.Web.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mango.Web.Controllers
{
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDTO loginRequestDTO = new LoginRequestDTO();

            return View(loginRequestDTO);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var roleList = new List<SelectListItem>()
            {
                new SelectListItem{Text = StaticDetails.RoleAdmin, Value = StaticDetails.RoleAdmin },
                new SelectListItem{Text = StaticDetails.RoleCustomer, Value = StaticDetails.RoleCustomer },
            };

            ViewBag.RoleList = roleList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistrationRequestDTO obj)
        {
            ResponseDTO result = await _authService.RegisterAsync(obj);
            ResponseDTO assignedRole;

            if (result != null && result.IsSuccess)
            {
                if (string.IsNullOrEmpty(obj.Role)) {
                    obj.Role = StaticDetails.RoleCustomer;
                }

                assignedRole = await _authService.AssignRoleAsync(obj);

                if (assignedRole != null && assignedRole.IsSuccess)
                {
                    TempData["success"] = "Registration Successful";
                    return RedirectToAction(nameof(Login));
                }
            }

            var roleList = new List<SelectListItem>()
            {
                new SelectListItem{Text = StaticDetails.RoleAdmin, Value = StaticDetails.RoleAdmin },
                new SelectListItem{Text = StaticDetails.RoleCustomer, Value = StaticDetails.RoleCustomer },
            };

            ViewBag.RoleList = roleList;

            return View(obj);
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
