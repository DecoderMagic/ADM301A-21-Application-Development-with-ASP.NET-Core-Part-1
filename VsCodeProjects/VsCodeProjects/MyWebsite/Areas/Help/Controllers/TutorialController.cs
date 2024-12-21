[Route("[area]/[controller]/[action]")]
[Area("Help")]
public class TutorialController : Controller
{
    [Route("/Help/Tutorial/{id?}")]
    public IActionResult Index(string id = "Page1")
    {
        return View(id);
    }
}
