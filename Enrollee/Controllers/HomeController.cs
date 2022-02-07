using Enrollee.Context;
using Enrollee.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Enrollee.Controllers
{
    public class HomeController : Controller
    {
        private readonly EnrolleContext _context;
        public HomeController(EnrolleContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendRequest(Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}