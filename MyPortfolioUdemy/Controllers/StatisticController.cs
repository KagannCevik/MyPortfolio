﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2=context.Messages.Count();
			ViewBag.v3=context.Messages.Where(x=>x.IsRead==false).Count();
			ViewBag.v4=context.Messages.Where(x=>x.IsRead==true).Count();
			ViewBag.v5 = context.Experiences.Count();
			ViewBag.v6 = context.testimonials.Count();
			ViewBag.v7 = context.Experiences.Where(x => x.Head == "Web Tasarım").Count();
			ViewBag.v8 = context.Experiences.Where(x => x.Head == "Masaüstü Uygulama").Count();
			ViewBag.v9 = context.Experiences.Where(x => x.Title == "E Ticaret Sitesi").Count();

			return View();
		}
	}
}
