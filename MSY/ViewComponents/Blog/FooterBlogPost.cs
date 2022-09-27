using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MSY.ViewComponents.Blog
{
	public class FooterBlogPost : ViewComponent
	{
		BlogManager _blogManager = new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = _blogManager.GetFooterBlogPost();
			return View(values);
		}
		
	}
}

