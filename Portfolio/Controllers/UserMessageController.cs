using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class UserMessageController : Controller
    {

        private readonly AppDbContext _context;

        public UserMessageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var messages = _context.UserMessages.ToList();
            return View(messages);
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var message = _context.UserMessages.Find(id);
            message.IsRead = true;
            _context.UserMessages.Update(message);
            _context.SaveChanges();
            return View(message);
        }
    }
}
