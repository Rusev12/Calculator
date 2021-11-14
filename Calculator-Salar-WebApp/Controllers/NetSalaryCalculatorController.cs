using Calculator_Salar_WebApp.Models;
using Calculator_Salar_WebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_Salar_WebApp.Controllers
{

    public class NetSalaryCalculatorController : Controller
    {
        private readonly ApplicationDbContext _context;
        public NetSalaryCalculatorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(NetSalaryCalculator _grossSalary)
        {
            if (ModelState.IsValid && _grossSalary != null)
            {
                var calculationResult = Formulas.ForNetSalaryAndEmployeeTaxesCalculationFromGrossSalary(_grossSalary);
                SaveResultsInDB(calculationResult);
                return RedirectToAction(nameof(CompleteCalculation), "NetSalaryCalculator", calculationResult) ;
            }
            return View(_grossSalary);
        }

        private void SaveResultsInDB(NetSalaryCalculator result)
        {
            _context.NetSalariesCalculator.Add(result);
            _context.SaveChanges();
        }

        public IActionResult CompleteCalculation(NetSalaryCalculator calculationResult)
        {
            return View(calculationResult);
        }

    }
}