using System;
using System.ComponentModel.DataAnnotations;

namespace ProvoMatjip.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            RestaurantRanking = rank;
        }

        [Required]
        public int RestaurantRanking { get; }

        [Required]
        public string RestaurantName { get; set; }

        //protect against null values in optional fields
#nullable enable
        public string? FavoriteDish { get; set; }
#nullable disable
        [Required]
        public string Address { get; set; }
#nullable enable
        public string? Phone { get; set; }
        public string? Website { get; set; }
#nullable disable
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Slapfish",
                FavoriteDish = "Clobster Grilled Cheese",
                Address = "3320 Digital Dr, Lehi",
                Phone = "385-455-4110",
                Website = "www.slapfishrestaurant.com"
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Pizzeria Limone",
                FavoriteDish = "Pera",
                Address = "1249 E Main St #120, Lehi",
                Phone = "801-331-8820",
                Website = "www.pizzerialimone.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Zubs Subs",
                FavoriteDish = "The Thanksgiving Sub (Only Available during November)",
                Address = "520 N Main St, Springville",
                Phone = "801-489-9484",
                Website = "www.zubssubs.com"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Fillings & Emulsions",
                FavoriteDish = null,
                Address = "326 W Center St, Provo,",
                Phone = "801-607-1593",
                Website = "www.fillingsandemulsions.com"
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Katsu City ",
                FavoriteDish = null,
                Address = "1700 N State St #23",
                Phone = "801-375-0818",
                Website = null
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
