using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultProjectInfoViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultProjectInfoViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var projects = _context.Projects.Include(p => p.ProjectTechStacks).ThenInclude(pts => pts.TechStack).Where(x => x.IsDone == true).ToList();
            return View(projects);
        }
    }
}
