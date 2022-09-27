using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MSY.Controllers
{
	public class ContactController : Controller
	{
		ContactManager _contactManager = new ContactManager(new EfContactRepository());
		// GET: /<controller>/
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			contact.ContactStatus = true;
			_contactManager.ContactAdd(contact);
			return View();
		}
	}
}

