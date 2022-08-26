using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MSY.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer _writer)
        {
            _writer.WriterAbout = "-";
            _writer.WriterStatus = true;
            writerManager.WriterAdd(_writer);
            return RedirectToAction("Index","Blog");
        }
    }
}
