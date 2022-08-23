using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.ViewModels
{
    public class ItemSizeViewModel
    {
        public int ItemSizeID { get; set; }

        public string itemSize { get; set; }

        public Decimal ItemSizePrice { get; set; }
        public bool IsRadio { get; set; }
        public ItemViewModel item { get; set; }
    }
}
