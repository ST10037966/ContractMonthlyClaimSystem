using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateClaim()
        {
            return View();
        }

        public IActionResult ViewClaims()
        {
            return View();
        }

        public IActionResult ApproveClaims()
        {
            return View();
        }
    }
}