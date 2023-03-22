using Formation.Abstructs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages.Restaurants
{
    public class CreateModel : PageModel
    {
        private readonly IRestaurantService restaurantService;

        [BindProperty]
        public Formation.dto.Restaurant Restaurant { get; set; }

        public CreateModel(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Restaurant = restaurantService.CreateRestaurant(Restaurant);

            return RedirectToPage("./List"); 
        }
    }
}
