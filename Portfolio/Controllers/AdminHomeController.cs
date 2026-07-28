using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class AdminHomeController : Controller
    {

        private readonly AppDbContext _context;

        public AdminHomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var modelValues = new DashboardViewModel
            {
                TotalProjectCount = _context.Projects.Count(),
                TotalSkillCount = _context.Skills.Count(x => x.IsActive == true),
                TotalMessagesCount = _context.UserMessages.Count(x => x.IsRead == false),
                TotalServiceCount = _context.Services.Count(),
            };

            return View(modelValues);
        }
    }
}
