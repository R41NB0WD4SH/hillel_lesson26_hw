using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hillel_Lesson26_HW.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;


namespace Hillel_Lesson26_HW.Controllers
{
    public class AboutMeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            var user = new AboutMeModel()
            {
                FirstName = "Denys",
                LastName = "Klymovets"
            };

            ViewBag.Message = "I am an active, communicable and responsible person. Able to learn fast, find creative solutions and approaches." +
                "Being high-motivated I’m sure I’ll manage to show fast and qualitative growth and we'll build an excellent co-working";

            user.HardSkills = new List<string>()
            {
                "C#/.NET",
                "OOP",
                "HTML5",
                "CSS",
                "JavaScript",
                "GIT",
                "SQL",
                "LINQ",
                "ASP.NET MVC Core",
                "Unit Test",
                "WPF",
                "REST.API",
                "Entity Framework Core"

            };


            return View(user);
        }
    }
}

