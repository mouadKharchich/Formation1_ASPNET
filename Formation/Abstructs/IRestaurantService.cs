using Formation.dto;

namespace Formation.Abstructs
{
    public interface IRestaurantService
    {
        List<Restaurant> GetRestaurants();

        Restaurant GetRestaurant(int id);

        Restaurant CreateRestaurant(Restaurant restaurant);

        Restaurant UpdateRestaurant(Restaurant newRestaurant);

        Restaurant DeleteRestaurant(int id);
    }
}
