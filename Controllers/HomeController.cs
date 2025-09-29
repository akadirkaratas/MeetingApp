

using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            //ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydin";
            //ViewBag.UserName = "Kadir";
            
            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydin";
            ViewData["UserName"] = "Kadir";

            return View();

        }
    }
}