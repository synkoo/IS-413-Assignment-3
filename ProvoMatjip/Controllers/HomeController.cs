using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvoMatjip.Models;

namespace ProvoMatjip.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                #nullable enable
                //List "it's all tasty", "coming soon" when empty
                string? dish = r.FavoriteDish ?? "It's all tasty!";
                string? site = r.Website ?? "Coming soon.";
                #nullable disable

                restaurantList.Add(string.Format("#{0}: {1} | Must-Try: {2} | Address: {3} | Contact: {4} | Website: {5}", r.RestaurantRanking, r.RestaurantName, dish, r.Address, r.Phone, site));
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult NewRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewRestaurant(Recommendation recommendation)
        {
            //Check validity of submitted form
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(recommendation);
                Response.Redirect("SuggestionList");
            }
            return View();
        }

        public ViewResult SuggestionList()
        {
            return View(TempStorage.Recommendations);
        }

        public IActionResult Privacy()
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
