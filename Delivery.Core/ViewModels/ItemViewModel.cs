using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.ViewModels
{
    public class ItemViewModel
    {
        public int ItemID { get; set; }
        public string ItemTitle { get; set; }
        public string? ImgURL { get; set; }
        public Decimal ItemPrice { get; set; }
        public string ItemDescriptoin { get; set; }
        public MenuViewModel menu { get; set; }
        public List<OptionViewModel> options { get; set; }
        public List<ItemSizeViewModel> itemSize { get; set; }

    }
}
