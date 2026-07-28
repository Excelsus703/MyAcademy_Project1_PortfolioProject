using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class SkillCategoryController : Controller
    {

        private readonly AppDbContext _context;

        public SkillCategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.SkillCategories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult NewCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewCategory(SkillCategory skillCategory)
        {
            _context.SkillCategories.Add(skillCategory);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var category = _context.SkillCategories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult EditCategory(SkillCategory skillCategory)
        {
            _context.SkillCategories.Update(skillCategory);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
