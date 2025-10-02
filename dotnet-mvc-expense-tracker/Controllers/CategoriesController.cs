using Microsoft.AspNetCore.Mvc;
using dotnet_mvc_expense_tracker.Models;
using System.Collections.Generic;

namespace dotnet_mvc_expense_tracker.Controllers
{
    public class CategoriesController : Controller
    {
        // Simulasi penyimpanan data sementara
        private static List<Category> categories = new List<Category>();

        // GET: /Categories
        public IActionResult Index()
        {
            return View(categories);
        }

        // GET: /Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Categories/Create
        [HttpPost]
        public IActionResult Create(Category model)
        {
            model.Id = categories.Count + 1;
            categories.Add(model);
            return RedirectToAction("Index");
        }
    }
}
