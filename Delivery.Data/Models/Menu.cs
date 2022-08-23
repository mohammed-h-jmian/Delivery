using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public string MenuName { get; set; }

        public int ResturantID { get; set; }
        public Resturant resturant { get; set; }
        public List<Item> items { get; set; }


    }
}
