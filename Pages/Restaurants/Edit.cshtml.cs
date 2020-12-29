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
    public class EditModel : PageModel
    {
        private readonly IRestaurant restaurantData;
        public Restaurant Restaurant { get; set; }
        public EditModel(IRestaurant RestaurantData)
        {
            restaurantData = RestaurantData;
        }
        public ActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetRestaurantById(restaurantId);
            return Restaurant == null ? RedirectToPage("./NotFound") : (ActionResult)Page();
        }
    }
}
