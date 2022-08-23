using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Dtos.OpeningDtos
{
    public class CreateOpeningDto
    {
        [Required]
        public string MondayOpen { get; set; }
        [Required]
        public string MondayClose { get; set; }
        [Required]
        public string TuesdayOpen { get; set; }
        [Required]
        public string TuesdayClose { get; set; }
        [Required]
        public string WednesdayOpen { get; set; }
        [Required]
        public string WednesdayClose { get; set; }
        [Required]
        public string ThursdayOpen { get; set; }
        [Required]
        public string ThursdayClose { get; set; }
    }
}
