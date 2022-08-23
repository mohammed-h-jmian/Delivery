using Delivery.Core.Dtos.RiderRegistrationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Services.RiderRegistrationServices
{
    public interface IRiderRegistrationService
    {
        Task<string> Create(RiderRegistrationDto dto); 
    }
}
