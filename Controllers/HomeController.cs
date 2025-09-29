

using MeetingApp.Models;
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

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Kadiköy, İstanbul ",
                Date = new DateTime(2025, 09, 30, 18, 30, 0),
                NumberOfPeople = 100
            };

            return View(meetingInfo);

        }
    }
}