using System;
using System.Collections.Generic;

//Model to store suggested restaurants in a list

namespace ProvoMatjip.Models
{
    public class TempStorage
    {
        public TempStorage()
        {

        }
        private static List<Recommendation> recommendations = new List<Recommendation>();

        public static IEnumerable<Recommendation> Recommendations => recommendations;

        public static void AddRestaurant(Recommendation recommendation)
        {
            recommendations.Add(recommendation);
        }
    }
}
