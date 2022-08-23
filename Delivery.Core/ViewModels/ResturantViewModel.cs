using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.ViewModels
{
    public class ResturantViewModel
    {
        public int ResturantID { get; set; }
        public string ResturantTitle { get; set; }
        public string ResturantKeywords { get; set; }
        public string ResturantType { get; set; }
        public string ResturantStatus { get; set; }
        public string ResturantDescriptoin { get; set; }
        public string ImgURl { get; set; }
        public CategoryViewModel category { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string GooglePluse { get; set; }
        public OpeningViewModel opening { get; set; }
        public List<MenuViewModel> Menus { get; set; }
        public string CreatedAt { get; set; }
    }
}
