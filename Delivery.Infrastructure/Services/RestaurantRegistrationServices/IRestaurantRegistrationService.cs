using Delivery.Core.Dtos.RestaurantRegistrationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Services.RestaurantRegistrationServices
{
    public interface IRestaurantRegistrationService
    {
        Task<string> Create(RestaurantRegistrationDto dto);




    }
}
