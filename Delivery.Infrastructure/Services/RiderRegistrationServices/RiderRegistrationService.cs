using AutoMapper;
using Delivery.Core.Dtos.RiderRegistrationDtos;
using Delivery.Data;
using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Services.RiderRegistrationServices
{
    public class RiderRegistrationService : IRiderRegistrationService
    {
        private readonly DeliveryDbContext _DB;
        private readonly IMapper _mapper;
        public RiderRegistrationService(DeliveryDbContext DB
            , IMapper mapper)
        {
            _DB = DB;
            _mapper = mapper;
        }
        public async Task<string> Create(RiderRegistrationDto dto)
        {
            var rider = _mapper.Map<RiderRegistration>(dto);

         await   _DB.riderRegistrations.AddAsync(rider);
            await _DB.SaveChangesAsync();

            return  $"{rider.Id}" ;
        }

  
    }
}
