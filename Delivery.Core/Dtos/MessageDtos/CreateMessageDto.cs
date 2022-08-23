using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Dtos.MessageDtos
{
    public class CreateMessageDto
    {
        [Required]
        [Display(Name = "Message Content")]
        public string MessageContent { get; set; }
        [Required]
        [Display(Name = "Message Content")]
        public string OwnerName { get; set; }
        [Required]
        [Display(Name = "Message Content")]
        public string OwnerEmail { get; set; }
        [Required]
        public string CreatedBy { get; set; }//userId


    }
}
