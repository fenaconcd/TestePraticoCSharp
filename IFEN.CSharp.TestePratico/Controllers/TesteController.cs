using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IFEN.CSharp.TestePratico.Models;

namespace IFEN.CSharp.TestePratico.Controllers
{
    public class TesteController : ControllerBase
    {
        public IActionResult Index()
        {
            // Use esta variável para acesso aos dados
            var dataContext = DataContext;

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
