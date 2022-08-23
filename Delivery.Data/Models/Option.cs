using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Option
    {
        public int OptionID { get; set; }
        [Required]
        public string OptionTitle { get; set; }
        [Required]
        public Decimal OptionPrice { get; set; }
        [Required]
        public bool IsRadio { get; set; }
        [Required]
        public int ItemID { get; set; }
        public Item item { get; set; }

    }
}
