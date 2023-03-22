using Formation.Abstructs;
using Formation.Services;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Formation.TagHelpers
{

    [HtmlTargetElement("count")]
    public class CountRestaurants : TagHelper
    {
        private readonly IRestaurantService restaurantService;

        public CountRestaurants(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }

        // this tag helper work in list restaurant (Restaurant/List)
        // it's use it to count number of customers and if list of customer is vide display vide! message 
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "count";
            int count = restaurantService.GetRestaurants().Count;
            if (count != 0)
            {
                output.Content.SetContent($"Count : {count}");
            }
            else
            {
                output.Content.SetContent($"Vide!");
            }
        }
    }
}
