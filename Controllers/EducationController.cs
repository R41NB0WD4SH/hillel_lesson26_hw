using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hillel_Lesson26_HW.Models;
using Microsoft.AspNetCore.Mvc;


namespace Hillel_Lesson26_HW.Controllers
{
    public class EducationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            var educationController = new EducationModel();

            var university1 = new EducationModel()
            {
                UniversityName = "Dnipro State Agrarian and Ecomomic University",
                Specialization = "Veterinary Medicine",
                Degree = "Bachelor",
                StydingPeriod = "09.2014 - 12.2018"
            };

            var university2 = new EducationModel()
            {
                UniversityName = "Dnipro State Agrarian and Ecomomic University",
                Specialization = "Public Administration",
                Degree = "Master's",
                StydingPeriod = "09.2018 - 03.2020"
            };

            var university3 = new EducationModel()
            {
                UniversityName = "Learning IT Center “LevelUp",
                StydingPeriod = "07.2022 - 02.2023"
            };

            var university4 = new EducationModel()
            {
                UniversityName = "Hillel IT School",
                StydingPeriod = "03.2023 - 06.2023"
            };

            educationController.EducationModels.Add(university1);
            educationController.EducationModels.Add(university2);
            educationController.EducationModels.Add(university3);
            educationController.EducationModels.Add(university4);


            return View(educationController);
        }
    }
}

