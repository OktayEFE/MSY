using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MSY.Controllers
{
	public class AboutController : Controller
	{
		AboutManager _aboutManager = new AboutManager(new EfAboutRepository());
		// GET: /<controller>/
		public IActionResult Index()
		{
			var value = _aboutManager.GetList();
			return View(value);
		}
		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();
		}
	}
}

