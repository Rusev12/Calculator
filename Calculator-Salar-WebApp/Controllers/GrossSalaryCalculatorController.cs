using Microsoft.AspNetCore.Mvc;

namespace Calculator_Salar_WebApp.Controllers
{
    public class GrossSalaryCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}