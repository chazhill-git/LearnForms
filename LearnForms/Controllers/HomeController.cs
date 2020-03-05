using LearnForms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LearnForms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PeopleList()
        {
            return View(BAL.API.PeopleWork.GetPeople().ToList()); 
        }
        public IActionResult EditPerson(int id)
        {
            return View(BAL.API.PeopleWork.GetPerson(id));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddPerson()
        {
            var p = new Person();

            return View(p);
        }

        [HttpPost]
        public IActionResult AddPerson(Person p)
        {
            var addPerson = new BAL.API.PeopleWork();
            addPerson.AddPerson(p);
            return View();
        }
    }
}
