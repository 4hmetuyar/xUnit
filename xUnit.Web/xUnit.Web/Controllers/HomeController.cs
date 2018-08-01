using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using xUnit.Web.Models;

namespace xUnit.Web.Controllers
{
    public class HomeController : Controller
    {
        public bool IsNoob { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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

        public bool BooleanAsserts()
        {
            return  true;
        }
    }
}
