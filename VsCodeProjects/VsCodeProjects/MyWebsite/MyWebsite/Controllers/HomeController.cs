using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Contact()
        {
            var contactData = new List<(string Type, string Value)>
            {
                ("Phone", "555-123-4567"),
                ("Email", "me@mywebsite.com"),
                ("Facebook", "facebook.com/mywebsite")
            };
            ViewData["ContactData"] = contactData;
            return View();
        }
    }
}
