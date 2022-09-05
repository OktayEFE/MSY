using System;
using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface INewsLetterService
	{
		void AddNewsLetter(NewsLetter newsLetter);
		List<NewsLetter> GetList();
	}
}

