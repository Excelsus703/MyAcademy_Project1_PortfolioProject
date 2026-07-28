using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class EducationController : Controller
    {

        private readonly AppDbContext _context;

        public EducationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var educations = _context.Educations.ToList();
            return View(educations);
        }

        [HttpGet]
        public IActionResult NewEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewEducation(Education education)
        {
            _context.Educations.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditEducation(int id)
        {
            var education = _context.Educations.Find(id);
            return View(education);
        }

        [HttpPost]
        public IActionResult EditEducation(Education education)
        {
            _context.Educations.Update(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEducation(int id)
        {
            var education = _context.Educations.Find(id);
            _context.Educations.Remove(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
