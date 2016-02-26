using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;

namespace GitHubSpike.Controllers
{
    [Authorize]
    public class IssuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
