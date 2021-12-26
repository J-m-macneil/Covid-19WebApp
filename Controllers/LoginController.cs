using Microsoft.AspNetCore.Mvc;
using MyFirstProjectWebApp.Models;
using MyFirstProjectWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProjectWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ProcessLogin(User user)
        {
            SecurityService securityService = new SecurityService();
            if (securityService.IsValid(user))
            {
                return View("LoginSuccess", user);
            }
            else
                return View("LoginFailure", user);
        }
    }
}
