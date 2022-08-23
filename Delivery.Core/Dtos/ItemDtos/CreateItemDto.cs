using Delivery.Core.Dtos.ItemSizeDtos;
using Delivery.Core.Dtos.OptionDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Dtos.ItemDtos
{
    public class CreateItemDto
    {
        [Required]
        public string ItemTitle { get; set; }
        public string? ImgURL { get; set; }
        [Required]
        public Decimal ItemPrice { get; set; }
        [Required]
        public string ItemDescriptoin { get; set; }
        public int MenuID { get; set; }

        public List<CreateOptionDto> options { get; set; }
        public List<CreateSizeDto> itemSize { get; set; }

    }
}
