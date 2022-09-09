using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MSY.Controllers
{
    public class CommentController : Controller
    {
        CommentManager _commentManager= new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }
		[HttpGet]
        public IActionResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public JsonResult PartialAddComment(Comment _comment)
        {
            _comment.CommentDate = DateTime.Parse(DateTime.UtcNow.ToLocalTime().ToShortDateString());
            _comment.CommentStatus = true;
            _comment.BlogId = 2;
            _commentManager.CommentAdd(_comment);
            return Json("Ok");
        }
        public IActionResult CommentListByBlog(int id)
        {
            var values = _commentManager.GetList(id);
            return PartialView(values);
        }
    }
}
