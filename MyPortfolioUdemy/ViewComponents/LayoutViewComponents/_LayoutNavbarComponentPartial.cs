using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
		MyPortfolioContext context= new MyPortfolioContext();
        public IViewComponentResult Invoke()
		{
			ViewBag.ToDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            //ViewBag.v2=context.ToDoLists.Count();
            var value = context.ToDoLists.Where(x=>x.Status == false).ToList();
            return View(value);
		}
	}
}