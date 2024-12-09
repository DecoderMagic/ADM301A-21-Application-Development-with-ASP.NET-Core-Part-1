using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FAQsApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace FAQsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly FAQsAppDbContext _context;

        public HomeController(FAQsAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var faqs = _context.FAQs != null 
                ? _context.FAQs.Include(f => f.Category).Include(f => f.Topic).ToList()
                : new List<FAQ>();
            return View(faqs);
        }

        public async Task<IActionResult> Topic(string id)
        {
            var faqs = _context.FAQs != null 
                ? await _context.FAQs.Include(f => f.Topic).Include(f => f.Category)
                            .Where(f => f.TopicId == id).ToListAsync()
                : new List<FAQ>();
            return View("Index", faqs);
        }

        public async Task<IActionResult> Category(string id)
        {
            var faqs = _context.FAQs != null 
                ? await _context.FAQs.Include(f => f.Topic).Include(f => f.Category)
                            .Where(f => f.CategoryId == id).ToListAsync()
                : new List<FAQ>();
            return View("Index", faqs);
        }
    }
}
