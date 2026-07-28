using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.AdminDashboard
{
    public class _AdminDashboardRecentProjectsViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _AdminDashboardRecentProjectsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var recentProjects = _context.Projects.OrderByDescending(projects => projects.Id).Take(5).ToList();
            return View(recentProjects);
        }
    }
}
