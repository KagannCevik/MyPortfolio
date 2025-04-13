using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.testimonials.ToList();
            return View(value);
        }
    } 
}
