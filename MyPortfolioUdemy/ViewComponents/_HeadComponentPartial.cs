using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewCompenents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
