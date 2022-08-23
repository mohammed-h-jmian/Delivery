using Delivery.Core.Dtos.ResturantDtos;
using Delivery.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Services.RestaurantServices
{
    public interface IResturantService
    {
        //  List<ResturantViewModel> GetAll();
        Task<string> Create(InterfaceResturantDto dto);
       Task<ResturantViewModel> Get(int id);
      //  void Delete(int id);
       

    }
}
