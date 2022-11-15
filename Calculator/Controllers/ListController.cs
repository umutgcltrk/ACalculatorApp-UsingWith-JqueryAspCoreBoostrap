using Calculator.Models.DbConnection;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Calculator.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index(string p)
        {
            using var c = new DatabaseContext();
            var allList = from x in c.Calculators select x;
            if (!string.IsNullOrEmpty(p))
            {
                allList = allList.Where(k => k.CreateTime.Contains(p));
            }
            return View(allList.ToList());
        }
    }
}
