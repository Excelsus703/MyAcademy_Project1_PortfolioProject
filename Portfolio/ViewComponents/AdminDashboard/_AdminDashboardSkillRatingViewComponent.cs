using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.AdminDashboard
{
    public class _AdminDashboardSkillRatingViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _AdminDashboardSkillRatingViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var skillsList = _context.Skills.OrderBy(skills => skills.Id).Take(4).ToList();
            return View(skillsList);
        }
    }
}
