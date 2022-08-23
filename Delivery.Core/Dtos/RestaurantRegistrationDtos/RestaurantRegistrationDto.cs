using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Dtos.RestaurantRegistrationDtos
{
    public class RestaurantRegistrationDto
    {
        //Personal data
        [Required]
        [Display(Name = "Name and Last Name")]
        public string OwnerName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string OwnerEmail { get; set; }
        [Required]
        [Display(Name = "Restaurant Name")]
        public string RestaurantName { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Required]
        public string CreatedBy { get; set; }
    }
}
