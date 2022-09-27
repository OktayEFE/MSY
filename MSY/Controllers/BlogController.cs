using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MSY.Controllers
{
	[AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager _blog = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = _blog.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.BlogId = id;
            var values = _blog.GetBlogById(id);
            return View(values);
        }
    }
}
