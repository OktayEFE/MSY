using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MSY.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager _newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());
		// GET: /<controller>/
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public JsonResult SubscribeMail(NewsLetter newsLetter)
		{
			newsLetter.MailStatus = true;
			try
			{
				if ((_newsLetterManager.GetList().Where(x => x.Mail == newsLetter.Mail)) != null)
				{
					return Json("Başarılı");
				}
				else
				{
					_newsLetterManager.AddNewsLetter(newsLetter);
					return Json("Kayıt Mevcut");
				}
			}
			catch (Exception ex)
			{
				return Json(ex);
			}
			
		}
	}
}

