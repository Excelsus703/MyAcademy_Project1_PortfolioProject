using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class SkillController : Controller
    {

        private readonly AppDbContext _context;

        public SkillController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var skills = _context.Skills.Include(s => s.SkillCategory).ToList();
            return View(skills);
        }

        [HttpGet]
        public IActionResult NewSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var skill = _context.Skills.Find(id);
            return View(skill);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var skill = _context.Skills.Find(id);
            _context.Skills.Remove(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
