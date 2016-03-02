using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;

namespace GitHubSpike.Controllers
{
    [Authorize]
    public class IssuesController : Controller
    {
        [HttpGet("~/")]
        public ActionResult Index() => View();
    }
}
