using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.ViewModels
{
    public class RiderRegistrationViewModel
    {
        public int Id { get; set; }
        public string RiderName { get; set; }
        public string RiderEmail { get; set; }
        public string RiderPhone { get; set; }
        public int RiderAge { get; set; }
        public string RiderGender { get; set; }
        public string City { get; set; }
        public string vehicle { get; set; }
        public string hearAboutUs { get; set; }
    }
}
