using Delivery.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Dtos.RiderRegistrationDtos
{
    public class RiderRegistrationDto
    {
        [Required]
        [Display(Name = "Rider Name")]
        public string RiderName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Rider Email")]
        public string RiderEmail { get; set; }
        [Required]
        [Display(Name = "Rider Phone")]
        public string RiderPhone { get; set; }
        [Required]
        [Display(Name = "Rider Age")]
        public int RiderAge { get; set; }
        [Required]
        [Display(Name = "Rider Gender")]
        public Gender RiderGender { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Vehicle")]
        public Vehicle vehicle { get; set; }
        [Required]
        [Display(Name = "Hear About Us")]
        public List<string> hearAboutUs { get; set; }
    }
}
