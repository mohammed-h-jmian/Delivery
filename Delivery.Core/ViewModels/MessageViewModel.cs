using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.ViewModels
{
    public class MessageViewModel
    {
        public int MessageID { get; set; }
        public string MessageContent { get; set; }
        public bool isRead { get; set; }
        public string OwnerName { get; set; }
        public string OwnerEmail { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }//userId

    }
}
