using BilbaApp.Data;
using BilbaApp.Models;
using BilbaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Diagnostics;

namespace BilbaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly NotebookDataContext context;

        public HomeController(NotebookDataContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var notebooks = this.context.Notebooks.Include(m => m.Spec).Select( m => new NotebookViewModal
            {
                Title = m.Title,
                ImageUrl = m.ImageUrl,  
                Price = m.Price,
                Specs = string.Join(',',m.Spec.Select( a => a.Spesifications))
                
            });   
            return View(notebooks); 
        }

        public IActionResult Privacy()
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