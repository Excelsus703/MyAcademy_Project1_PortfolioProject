using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class ExperienceController : Controller
    {

        private readonly AppDbContext _context;

        public ExperienceController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IActionResult Index()
        {
            var experiences = _context.Experiences.ToList();
            return View(experiences);
        }

        [HttpGet]
        public IActionResult NewExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewExperience(Experience experience)
        {
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var experience = _context.Experiences.Find(id);
            return View(experience);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var experience = _context.Experiences.Find(id);
            _context.Experiences.Remove(experience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
