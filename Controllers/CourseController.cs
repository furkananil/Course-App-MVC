using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Apps;
            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply(Candidate model)
        {
            if(Repository.Apps.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("","There is an already application for you.");
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