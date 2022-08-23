using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.ViewModels
{
    public class MenuViewModel
    {
        public int MenuID { get; set; }
        public string MenuName { get; set; }

        public ResturantViewModel resturant { get; set; }
        public List<ItemViewModel> items { get; set; }

    }
}
