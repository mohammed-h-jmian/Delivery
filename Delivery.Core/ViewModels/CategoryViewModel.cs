﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<ResturantViewModel> Resturants { get; set; }
    }
}
