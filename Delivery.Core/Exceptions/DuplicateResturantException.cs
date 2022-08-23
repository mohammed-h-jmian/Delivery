using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Exceptions
{
    public class DuplicateResturantException :Exception
    {
        public DuplicateResturantException():base("Duplicate Resturant Exception")
        {
        }
    }
}
