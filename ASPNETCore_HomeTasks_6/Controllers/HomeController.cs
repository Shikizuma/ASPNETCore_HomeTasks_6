using ASPNETCore_HomeTasks_6.Interfaces;
using ASPNETCore_HomeTasks_6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNETCore_HomeTasks_6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IListService _strListService;

        public HomeController(ILogger<HomeController> logger, IListService strListService)
        {
            _logger = logger;
            _strListService = strListService;
        }

        public IActionResult Index()
        {
            var list = _strListService.GetList();
            return View(list);
        }

  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}