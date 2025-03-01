using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            string message = $"Merhaba saat şimdi: {DateTime.Now.ToString()}";
            return View("Index", message);
        }
        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ahmet",
                "Mehmet",
                "Can"
            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1, FirstName="Ahmet", LastName="Yılmaz", Age=20},
                new Employee(){Id=2, FirstName="Hilmi", LastName="Dağdelen", Age=25},
                new Employee(){Id=3, FirstName="Selim", LastName="Halıcı", Age=48},
            };
            return View(list);
        }
    }
}
