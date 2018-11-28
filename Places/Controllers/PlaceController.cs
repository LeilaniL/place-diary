using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlaceDiary.Models;


namespace PlaceDiary.Controllers

{
    public class PlaceController : Controller
    {

        [HttpGet("/place")]
        public ActionResult PlaceDiary()
        {
            List<Place> allPlace = Place.GetAll();
            return View(allPlace);
        }
        [HttpGet("/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost("/place")]
        public ActionResult Create(string cityName, string description)
        {
            Place myCity = new Place(cityName, description);
            return RedirectToAction("PlaceDiary");
        }

    }
}