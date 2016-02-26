using System.Threading.Tasks;
using Microsoft.AspNet.Authentication.Cookies;
using Microsoft.AspNet.Http.Authentication;
using Microsoft.AspNet.Mvc;
using Mvc.Client.Extensions;
using System.Linq;

namespace GitHubSpike.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet("~/signin")]
        public IActionResult SignIn() => View("SignIn", HttpContext.GetExternalProviders().Single(s => s.AuthenticationScheme.ToLower() == "github"));

        [HttpPost("~/signin")]
        public IActionResult SignIn([FromForm] string provider) 
        {
            return new ChallengeResult(provider, new AuthenticationProperties { RedirectUri = "/" });
        }

        [HttpGet("~/signout")]
        [HttpPost("~/signout")]
        public async Task<IActionResult> SignOut() 
        {
            await HttpContext.Authentication.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Issues");
        }
    }
}
