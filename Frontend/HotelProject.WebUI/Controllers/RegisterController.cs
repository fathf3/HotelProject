﻿using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.AppUserDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDTO createNewUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                FirstName = createNewUserDTO.FirstName,
                Email = createNewUserDTO.Mail,
                LastName = createNewUserDTO.LastName,
                UserName = createNewUserDTO.UserName,
                WorkLocationID = 1
            };
            var result = await _userManager.CreateAsync(appUser, createNewUserDTO.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
