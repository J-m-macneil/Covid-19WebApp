using Microsoft.AspNetCore.Mvc;
using MyFirstProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProjectWebApp.Controllers
{
    public class AccountController : Controller
    {
        static List<AccountModel> accounts = new List<AccountModel>();
        public IActionResult Index()
        {
            return View(accounts);
        }

        //Create a method that will create a new account.
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details(AccountModel account)
        {
            accounts.Add(account);
            return View("Details", account);
        }
    }
}
