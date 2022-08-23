using Delivery.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Resturant : BaseEntity
    {
        public int ResturantID { get; set; }
        public string ResturantTitle { get; set; }
        public string ResturantKeywords { get; set; }
        public ResturantType ResturantType  { get; set; }
        public ResturantStatus ResturantStatus { get; set; }
        public string ResturantDescriptoin { get; set; }
        public string? ImgURl { get; set; }
        public int CategoryID { get; set; }
        public Category category { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }
        public string? Email { get; set; }
        public string? Twitter { get; set; }
        public string? Facebook { get; set; }
        public string? GooglePluse { get; set; }
        public int OpeningID { get; set; }
        public Opening opening { get; set; }

        public List<Menu> menus { get; set; }

        public Resturant()
        {
            ResturantStatus = ResturantStatus.Pending;
        }

    }
}
