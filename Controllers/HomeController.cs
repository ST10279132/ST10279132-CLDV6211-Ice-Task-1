// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace AppointmentSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string password)
        {
            if (password == "mypassword")
            {
                // Set session flag to indicate user is logged in
              

                // Redirect to the "Index" view for HomeController
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Incorrect password";
                return View("Index");
            }
        }

    }
}

    


