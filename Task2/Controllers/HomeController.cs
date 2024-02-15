using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task2.Interfaces;
using Task2.Models;
using Task2.Services;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICalc _calc;

        public HomeController(ILogger<HomeController> logger, ICalc calc)
        {
            _logger = logger;
            _calc = calc;
        }

        public IActionResult Index(double number1, double number2, string operation)
        {
            double result;
            switch (operation)
            {
                case "add":
                    result = _calc.Add(number1, number2);
                    break;
                case "subtract":
                    result = _calc.Substract(number1, number2);
                    break;
                case "multiply":
                    result = _calc.Multiply(number1, number2);
                    break;
                case "divide":
                    try
                    {
                        result = _calc.Divide(number1, number2);
                    }
                    catch 
                    {
                        ViewBag.Message = "Division by zero is not allowed";
                        return View();
                    }
                    break;
                default:
                    ViewBag.Message = "Invalid operation";
                    return View();
            }
            ViewBag.Result = result;
            return View();
        }

   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}