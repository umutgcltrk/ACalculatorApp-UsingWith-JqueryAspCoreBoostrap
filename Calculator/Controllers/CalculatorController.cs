using Calculator.Models.DbConnection;
using Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.Calculator calculator)
        {
            CalculatorService calculatorService = new CalculatorService();
            calculatorService.Transactions(calculator);
            
            var jsonCalculate = JsonConvert.SerializeObject(calculator);
            return Json(jsonCalculate);
        }
    }
}