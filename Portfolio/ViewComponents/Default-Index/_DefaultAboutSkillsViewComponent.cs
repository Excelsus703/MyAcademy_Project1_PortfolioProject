using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultAboutSkillsViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultAboutSkillsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var categoriesWithSkills = _context.SkillCategories.Include(x => x.Skills).Where(x => x.Skills.Any(s => s.IsActive)).ToList();
            return View(categoriesWithSkills);
        }
    }
}
