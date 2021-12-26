using Microsoft.AspNetCore.Mvc;
using MyFirstProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProjectWebApp.Controllers
{
    public class AppointmentController : Controller
    {
        static List<AppointmentModel> appointments = new List<AppointmentModel>();
        public IActionResult Index()
        {
            return View(appointments);
        }

        //Create a method that will create a new appointment.
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details(AppointmentModel appointment)
        {
            appointments.Add(appointment);
            return View("Details", appointment);
        }
    }
}
