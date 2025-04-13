using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
    public class LoyoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
