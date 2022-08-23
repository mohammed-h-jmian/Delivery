using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.ViewModels
{
    public class OpeningViewModel
    {
        public int OpeningID { get; set; }
        public string MondayOpen { get; set; }
        public string MondayClose { get; set; }
        public string TuesdayOpen { get; set; }
        public string TuesdayClose { get; set; }
        public string WednesdayOpen { get; set; }
        public string WednesdayClose { get; set; }
        public string ThursdayOpen { get; set; }
        public string ThursdayClose { get; set; }
    }
}
