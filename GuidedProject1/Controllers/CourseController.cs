using Microsoft.AspNetCore.Mvc;
using GuidedProject1.Models;


namespace GuidedProject1.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]//HTTP POST PROTOKOLU
        [ValidateAntiForgeryToken]// Güvenlik icin
        public IActionResult Apply([FromForm] Candidate model)
        {
            if (Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("","Aynı email ile zaten bir kayıt var!");
            }
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            return View();
        }
    }
}
