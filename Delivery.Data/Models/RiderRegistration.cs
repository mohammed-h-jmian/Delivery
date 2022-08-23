using Delivery.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class RiderRegistration
    {
        public int Id { get; set; }
        public string RiderName { get; set; }
        public string RiderEmail { get; set; }
        public string RiderPhone { get; set; }
        public int RiderAge { get; set; }
        public Gender RiderGender { get; set; }
        public string City { get; set; }
        public Vehicle vehicle { get; set; }
        public string hearAboutUs { get; set; }
    }
}
