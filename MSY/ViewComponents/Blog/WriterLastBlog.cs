using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MSY.ViewComponents.Blog
{
	public class WriterLastBlog:ViewComponent
	{
		BlogManager _blogManager = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			var values = _blogManager.GetBlogListByWriter(1);
			return View(values);
		}
	}
}

