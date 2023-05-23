using exrsis_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace exrsis_1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult reverse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult reverse(Text text)
        {

            string result = "";
            for (int i = text.Name.Length - 1; i >= 0; i--)
            {
                result += text.Name[i];
            }
            ViewBag.n = result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}