using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Dtos.OptionDtos
{
    public class CreateOptionDto
    {
        [Required]
        public string OptionTitle { get; set; }
        [Required]
        public Decimal OptionPrice { get; set; }
        [Required]
        public bool IsRadio { get; set; }
        [Required]
        public int ItemID { get; set; }

    }
}
