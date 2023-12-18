using Lesson43_Task.DAL;
using Lesson43_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson43_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appContext;

        public HomeController(AppDbContext appContext)
        {
            _appContext = appContext;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Account_Dashboard()
        {
            return View();
        }
        public IActionResult Account_Edit()
        {
            return View();
        }

        public IActionResult Account_Edit_Address()
        {
            return View();
        }

        public IActionResult Account_Orders()
        {
            return View();
        }

        public IActionResult Account_Wishlist()
        {
            return View();
        }

        public IActionResult Blog_List2()
        {
            return View();
        }

        public IActionResult Blog_Single()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Coming_Soon()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult Login_Register()
        {
            return View();
        }

        public IActionResult Product2_Variable()
        {
            return View();
        }

        public IActionResult Product6_Outofstock()
        {
            return View();
        }

        public IActionResult Reset_Password()
        {
            return View();
        }

        public IActionResult Shop_Cart()
        {
            return View();
        }

        public IActionResult Shop_Checkout()
        {
            return View();
        }

        public IActionResult Shop_Order_Complete()
        {
            return View();
        }


        public IActionResult Shop3()
        {
            return View();
        }

        public IActionResult Shop12()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}