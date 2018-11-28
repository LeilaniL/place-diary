using Microsoft.AspNetCore.Mvc;
using PlaceDiary.Models;

namespace PlaceDiary.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
