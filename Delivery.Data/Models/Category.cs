using System.Collections.Generic;

namespace Delivery.Data.Models
{
    public class Category : BaseEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Resturant> Resturants { get; set; }
    }
}
