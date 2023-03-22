using Formation.Abstructs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages.Restaurant
{
    public class ListModel : PageModel
    {
        private readonly IRestaurantService restaurantService;

        public List<Formation.dto.Restaurant> Restaurants { get; set; }

        public ListModel(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }
        public void OnGet()
        {
           Restaurants=restaurantService.GetRestaurants();  
        }
    }
}
