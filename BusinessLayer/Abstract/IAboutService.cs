using System;
using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IAboutService
	{
		List<About> GetList();
	}
}

