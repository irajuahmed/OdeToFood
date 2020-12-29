using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurant _restaurant;
        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurant restaurant)
        {
            _restaurant = restaurant;
        }

        public ActionResult OnGet(int restaurantId)
        {
            Restaurant = new Restaurant();
            Restaurant= _restaurant.GetRestaurantById(restaurantId);
            if (Restaurant == null)
                return RedirectToPage("./NotFound");
            else
            return Page();
        }
    }
}
