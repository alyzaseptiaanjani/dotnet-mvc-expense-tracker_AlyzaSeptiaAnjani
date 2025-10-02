using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_expense_tracker.Controllers
{
    public class BudgetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
