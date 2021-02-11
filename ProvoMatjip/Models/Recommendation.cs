using System;
using System.ComponentModel.DataAnnotations;

namespace ProvoMatjip.Models
{
    public class Recommendation
    {
        [Required]
        public string Submitter { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        [Required]
        public string FavoriteDish { get; set; }

        //Making sure phone number is valid
        [Required, RegularExpression(@"^[2-9]\d{2}-\d{3}-\d{4}$", ErrorMessage ="Please Check Phone number format: 800-555-5555 (First digit between 2 and 9)")]
        public string Phone { get; set; }

    }
}
