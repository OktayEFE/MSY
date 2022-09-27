using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MSY.Controllers
{
	[AllowAnonymous]
	public class WriterController : Controller
	{
		
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult WriterSidebarPartial()
		{
			return PartialView();
		}
		public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}
	}
}

