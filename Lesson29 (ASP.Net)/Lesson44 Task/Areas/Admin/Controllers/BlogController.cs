using Lesson43_Task.DAL;
using Lesson43_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson43_Task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _appContext;
        public BlogController(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public IActionResult Index()
        {
            return View(_appContext.Blogs.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            _appContext.Blogs.Add(blog);
            _appContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
