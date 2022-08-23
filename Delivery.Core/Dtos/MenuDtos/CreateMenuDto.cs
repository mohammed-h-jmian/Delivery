using Delivery.Core.Dtos.ItemDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Dtos.MenuDtos
{
    public class CreateMenuDto
    {
        [Required]
        [Display(Name = "Menu Name")]
        public string MenuName { get; set; }
        public List<CreateItemDto> items { get; set; }

    }
}
