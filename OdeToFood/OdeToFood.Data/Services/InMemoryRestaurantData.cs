using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Shish", Cuisine = CuisineType.Mediterranean},
                new Restaurant { Id = 1, Name = "Himalayan", Cuisine = CuisineType.Nepali},
                new Restaurant { Id = 1, Name = "Chipotle", Cuisine = CuisineType.Mexican }
            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r=> r.Name);
        }
    }
}
