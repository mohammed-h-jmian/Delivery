using Delivery.Core.Dtos.ItemDtos;
using Delivery.Core.Dtos.ItemSizeDtos;
using Delivery.Core.Dtos.MenuDtos;
using Delivery.Core.Dtos.OpeningDtos;
using Delivery.Core.Dtos.OptionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Dtos.ResturantDtos
{
    public class InterfaceResturantDto
    {
        public CreateOpeningDto opening { get; set; }
        public CreateResturantDto Resturant { get; set; }
        public CreateMenuDto Menu { get; set; }
        public CreateItemDto Item { get; set; }
        public CreateSizeDto Size { get; set; }
        public CreateOptionDto Option { get; set; }

    }
}
