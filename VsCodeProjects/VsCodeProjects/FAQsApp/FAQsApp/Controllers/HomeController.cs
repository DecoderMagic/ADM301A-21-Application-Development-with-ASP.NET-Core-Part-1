using Microsoft.AspNetCore.Mvc;
using FAQsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly FAQsAppDbContext _context;

        public HomeController(FAQsAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? type, string? id)
        {
            List<FAQ> faqs;

            if (_context.FAQs == null)
            {
                faqs = new List<FAQ>();
            }
            else if (type == "category" && !string.IsNullOrEmpty(id))
            {
                faqs = await _context.FAQs.Include(f => f.Topic).Include(f => f.Category)
                    .Where(f => f.CategoryId == id)
                    .ToListAsync();
            }
            else if (type == "topic" && !string.IsNullOrEmpty(id))
            {
                faqs = await _context.FAQs.Include(f => f.Topic).Include(f => f.Category)
                    .Where(f => f.TopicId == id)
                    .ToListAsync();
            }
            else
            {
                faqs = await _context.FAQs.Include(f => f.Topic).Include(f => f.Category).ToListAsync();
            }

            return View(faqs);
        }
    }
}
