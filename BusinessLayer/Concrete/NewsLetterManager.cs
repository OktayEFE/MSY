using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsLetter;

		public NewsLetterManager(INewsLetterDal newsLetter)
		{
			_newsLetter = newsLetter;
		}

		public void AddNewsLetter(NewsLetter newsLetter)
		{
			_newsLetter.Insert(newsLetter);
		}

		public List<NewsLetter> GetList()
		{
			return _newsLetter.GetListAll();
		}
	}
}

