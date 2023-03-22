using Formation.Abstructs;
using Formation.dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages.Restaurants
{
    public class EditModel : PageModel
    {

        private readonly IRestaurantService restaurantService;

        [BindProperty]
        public Formation.dto.Restaurant Restaurant { get; set; }

        public EditModel(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }
        public IActionResult OnGet(int id)
        {
            Restaurant=restaurantService.GetRestaurant(id);

            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            Restaurant = restaurantService.UpdateRestaurant(Restaurant);

            return RedirectToPage("./List"); ;

        }
    }
}
