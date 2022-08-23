using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class RestaurantRegistration : BaseEntity
    {
        public int Id { get; set; }
        //Personal data
        [Required]
        public string OwnerName { get; set; }
        [Required]
        public string OwnerEmail { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
