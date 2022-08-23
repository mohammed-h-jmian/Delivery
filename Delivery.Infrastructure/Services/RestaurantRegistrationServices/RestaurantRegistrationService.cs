using AutoMapper;
using Delivery.Core.Dtos.RestaurantRegistrationDtos;
using Delivery.Data;
using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Services.RestaurantRegistrationServices
{
    public class RestaurantRegistrationService : IRestaurantRegistrationService
    {
        private readonly DeliveryDbContext _DB;
        private readonly IMapper _mapper;
        public RestaurantRegistrationService(DeliveryDbContext DB
            , IMapper mapper)
        {
            _DB = DB;
            _mapper = mapper;
        }
        public async Task<string> Create(RestaurantRegistrationDto dto)
        {
            var restaurant = _mapper.Map<RestaurantRegistration>(dto);

          await  _DB.restaurantRegistrations.AddAsync(restaurant);
          await _DB.SaveChangesAsync();

            return  $"{restaurant.Id}" ;
        }

    }
}
