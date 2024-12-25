using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValidationAttributes.Models;

namespace ValidationAttributes.Controllers
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

        [HttpPost]
        public IActionResult Index(Student Stu) //all the datas of submit Form will be stored in stu
        {
            if (ModelState.IsValid) // if the all inputed data in form is valid then this will executed as it only executed if it is true
            {
                ModelState.Clear(); // for clearing the all inputed data in form after submitting the Form
            }
                return View();
            
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
    }
}
