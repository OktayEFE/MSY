using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MSY.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Index(Writer writer)
		{
			Context _context = new Context();
			var value = _context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
			if(value != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,writer.WriterMail)
				};
				var useridentity = new ClaimsIdentity(claims,"Oktay");
				ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index","Writer");
			}
			else
			{
				return View();
			}
			
		}
	}
}

