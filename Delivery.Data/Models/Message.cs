using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Message : BaseEntity
    {
        public int MessageID { get; set; }
        public string MessageContent { get; set; }
        public bool isRead { get; set; }
        public string OwnerName { get; set; }
        public string OwnerEmail { get; set; }
        public Message()
        {
            isRead = false;
        }
    }
}
