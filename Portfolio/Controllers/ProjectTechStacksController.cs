using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ProjectTechStacksController : Controller
    {

        private readonly AppDbContext _context;

        public ProjectTechStacksController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Eager Loading
            var projectTechStacks = _context.ProjectTechStacks
                                    .Include(x => x.Project)
                                    .Include(y => y.TechStack).ToList(); // önce belleğe çekiyoruz, GroupBy + string.Join için gerekli


            var groupedData = projectTechStacks
                              .GroupBy(x => new { x.Project.Id, x.Project.Name })
                              .Select(group => new ProjectTechStacksIndexViewModel
                              {
                                  ProjectId = group.Key.Id,
                                  ProjectName = group.Key.Name,
                                  UsedTechnologies = string.Join(", ", group.Select(x => x.TechStack.Name))
                              }).ToList();

            return View(groupedData);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var projects = _context.Projects.ToList();
            var techStacks = _context.TechStacks.ToList();

            ViewBag.Projects = (from project in projects
                                select new SelectListItem
                                {
                                    Text = project.Name,
                                    Value = project.Id.ToString()
                                }).ToList();

            ViewBag.TechStacks = (from tech in techStacks
                                  select new SelectListItem
                                  {
                                      Text = tech.Name,
                                      Value = tech.Id.ToString()
                                  }).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjectTechStack projectTechStack)
        {
            _context.ProjectTechStacks.Add(projectTechStack);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
