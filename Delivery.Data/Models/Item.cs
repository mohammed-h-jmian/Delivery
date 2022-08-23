using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        [Required] 
        public string ItemTitle { get; set; }
        public string? ImgURL { get; set; }
        [Required] 
        public Decimal ItemPrice { get; set; }
        [Required]
        public string ItemDescriptoin { get; set; }
        public int MenuID { get; set; }
        public Menu menu { get; set; }


        public List<Option> options { get; set; }
        public List<ItemSize> itemSize { get; set; }




    }
}
