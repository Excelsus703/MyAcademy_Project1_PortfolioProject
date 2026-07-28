using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.AdminDashboard
{
    public class _AdminDashboardRecentMessagesViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _AdminDashboardRecentMessagesViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var recentMessages = _context.UserMessages.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(recentMessages);
        }
    }
}
