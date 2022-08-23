using Delivery.Core.Dtos.RiderRegistrationDtos;
using Delivery.Infrastructure.Services.RiderRegistrationServices;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Web.Controllers
{
    public class RiderRegistrationController : Controller
    {
        private readonly IRiderRegistrationService _rider;
        public RiderRegistrationController(IRiderRegistrationService rider)
        {
            _rider = rider;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RiderRegistrationDto dto)
        {

            _rider.Create(dto);

            return View();
        }
    }
}
