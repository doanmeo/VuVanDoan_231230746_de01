using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VuVanDoan_231230746_de01.Models;

namespace VuVanDoan_231230746_de01.Controllers
{
    public class vvdHomeController : Controller
    {
        private readonly ILogger<vvdHomeController> _logger;

        public vvdHomeController(ILogger<vvdHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult VvdIndex()
        {
            return View();
        }

        public IActionResult VvdPrivacy()
        {
            return View();
        }

        public IActionResult VvdContact()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult VvdError()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
