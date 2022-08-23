using Delivery.Core.Dtos.MenuDtos;
using Delivery.Core.Dtos.OpeningDtos;
using Delivery.Core.Enums;
using Delivery.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Dtos.ResturantDtos
{
    public class CreateResturantDto
    {
        [Required]
        [Display(Name = "Resturant title")]
        public string ResturantTitle { get; set; }
        [Required]
        [Display(Name = "Resturant keywords")]
        public string ResturantKeywords { get; set; }
        [Required]
        [Display(Name = "Resturant type")]
        public ResturantType ResturantType { get; set; }
        [Required]
        [Display(Name = "Resturant descriptoin")]
        public string ResturantDescriptoin { get; set; }
        public string? ImgURl { get; set; }
        public int CategoryID { get; set; }
        [Display(Name = "Resturant Phone")]
        public string? Phone { get; set; }
        [Display(Name = "Resturant Website")]
        public string? Website { get; set; }
        [Display(Name = "Resturant Email")]
        public string? Email { get; set; }
        [Display(Name = "Resturant Twitter")]
        public string? Twitter { get; set; }
        [Display(Name = "Resturant Facebook")]
        public string? Facebook { get; set; }
        [Display(Name = "Resturant google luse")]
        public string? GooglePluse { get; set; }
      
    }
}
