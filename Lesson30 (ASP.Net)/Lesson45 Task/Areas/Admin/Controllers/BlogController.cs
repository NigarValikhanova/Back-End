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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var editBlog = _appContext.Blogs.Find(id);

            if (editBlog != null)
            {
                return View(editBlog);

            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Blog blog)
        {
            var oldBlog = _appContext.Blogs.Find(blog.Id);

            if (oldBlog != null)
            {
                oldBlog.Title = blog.Title;
                oldBlog.Text = blog.Text;
                _appContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var currentBlog = _appContext.Blogs.Find(id);
            if (currentBlog != null)
            {
                _appContext.Blogs.Remove(currentBlog);
                _appContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
