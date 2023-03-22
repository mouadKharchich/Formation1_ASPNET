using Formation.Abstructs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        
        private readonly IRestaurantService restaurantService;

        public Formation.dto.Restaurant restaurant { get; set; }
        public DetailModel(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }
        public IActionResult OnGet(int id)
        {
            restaurant=restaurantService.GetRestaurant(id);

            if (restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();

        }
    }
}
