using interface_sugarcane_to_SAP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace interface_sugarcane_to_SAP.Controllers
{
    public class GetpostPngsqlController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public GetpostPngsqlController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Show()
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
