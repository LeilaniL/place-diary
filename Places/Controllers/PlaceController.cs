using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlaceDiary.Models;
using System;

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
        public ActionResult Create(string cityName)
        {
            Place myCity = new Place(cityName);
            Console.WriteLine(myCity.GetCityName());
            return RedirectToAction("PlaceDiary");
        }

    }
}