using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.ViewModels
{
    public class OptionViewModel
    {
        public int OptionID { get; set; }
        public string OptionTitle { get; set; }
        public Decimal OptionPrice { get; set; }
        public bool IsRadio { get; set; }
        public ItemViewModel item { get; set; }
    }
}
