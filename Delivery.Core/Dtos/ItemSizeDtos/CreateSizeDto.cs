using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Dtos.ItemSizeDtos
{
    public class CreateSizeDto
    {
        [Required]
        [DisplayName("Size")]
        public string itemSize { get; set; }
        [Required]
        [DisplayName("Price")]
        public Decimal ItemSizePrice { get; set; }
        [Required]
        public bool IsRadio { get; set; }
        public int ItemID { get; set; }
    }
}
