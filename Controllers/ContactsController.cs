using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hillel_Lesson26_HW.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hillel_Lesson26_HW.Controllers
{
    public class ContactsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            var contact = new ContactsModel()
            {
                PhoneNumber = "+380996815973",
                Email = "den.kli2511@gmail.com",
                Telegram = "dj_fuego",
                Linkedin = "https://www.linkedin.com/in/denys-klymovets-272a91262/"
            };

            return View(contact);
        }
    }
}

