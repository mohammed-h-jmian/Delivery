using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.ViewModels
{
    public class RestaurantRegistrationViewModel
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public string OwnerEmail { get; set; }
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CreatedAt { get; set; }
    }
}
