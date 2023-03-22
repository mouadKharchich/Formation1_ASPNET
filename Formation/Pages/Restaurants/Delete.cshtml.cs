using Formation.Abstructs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages.Restaurants
{
    public class DeleteModel : PageModel
    {
        private readonly IRestaurantService _restaurantService
            ;

        public DeleteModel(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public Formation.dto.Restaurant Restaurant { get; set; }

        public IActionResult OnGet(int id)
        {
            Restaurant = _restaurantService.GetRestaurant(id);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var restaurant = _restaurantService.DeleteRestaurant(id);

            if (restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return RedirectToPage("./List");
        }
    }
}
