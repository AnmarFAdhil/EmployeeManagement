using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public IActionResult Index()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // Simple demo login - in real app, use proper authentication
            if (username == "admin" && password == "password")
            {
                // Set a simple session flag
                HttpContext.Session.SetString("IsLoggedIn", "true");
                return RedirectToAction("Index", "Employee");
            }
            ViewBag.Error = "Invalid credentials";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("IsLoggedIn");
            return RedirectToAction("Index");
        }
    }
}