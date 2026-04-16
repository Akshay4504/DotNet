using Microsoft.AspNetCore.Mvc;
using MyCoreWebApp.Models;
using System.Diagnostics;

namespace MyCoreWebApp.Controllers
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
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public ContentResult MyContent()
        {
            //return Content("i am ContentResult");
            return Content("<script>alert('Hi! I am akshayanand')</script>","text/html");
            //return Content("<h2>Akshay anand</h2>", "text/html");
        }
        public FileResult MyFile()
        {
            return File("~/Files/text.txt", "text/plain");
        }

        public JsonResult Myjson()
        {
            var jsonData = new
            {
                Name = "Pappaya",
                Id = 4,
                DateOfBirth = new DateTime(1969, 07, 05)
            };
            return Json(jsonData);
        }
        public RedirectResult MyRedirect()
        {
            return Redirect("http://www.msn.com");
        }

        public RedirectToRouteResult MyRedirectRoute()
        {
            return RedirectToRoute(new{ controller="Name",action="Index"});
        }

        public RedirectToActionResult MyRedirect2Action()
        {
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
