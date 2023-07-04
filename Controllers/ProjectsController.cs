using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hillel_Lesson26_HW.Models;
using Microsoft.AspNetCore.Mvc;


namespace Hillel_Lesson26_HW.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            var projects = new ProjectsModel();

            projects.ProjectsUrls = new List<string>()
            {
                "https://github.com/R41NB0WD4SH/hillel_lesson25_hw",
                "https://github.com/R41NB0WD4SH/hillel_lesson16_hw",
                "https://github.com/R41NB0WD4SH/hillel_lesson12_hw"
            };

            return View(projects);
        }
    }
}

