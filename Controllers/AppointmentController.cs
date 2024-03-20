// Controllers/AppointmentController.cs
using System;
using System.Collections.Generic;
using AppointmentSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentSystem.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            // Retrieve appointments from database or mock data
            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment { Id = 1, Title = "Meeting", DateTime = DateTime.Now, Location = "Conference Room" },
                new Appointment { Id = 2, Title = "Lunch", DateTime = DateTime.Now.AddDays(1), Location = "Restaurant" }
            };

            return View(appointments);
        }

        // Other CRUD actions (Create, Update, Delete) can be implemented here
    }
}
