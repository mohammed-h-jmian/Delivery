using Delivery.Core.Dtos.RestaurantRegistrationDtos;
using Delivery.Infrastructure.Services.RestaurantRegistrationServices;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Web.Controllers
{
    public class RestaurantRegistrationController : Controller
    {
        private readonly IRestaurantRegistrationService _RestaurantRegistrationService;
        
        public RestaurantRegistrationController(IRestaurantRegistrationService restaurantRegistrationService)
        {
            _RestaurantRegistrationService = restaurantRegistrationService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RestaurantRegistrationDto dto)
        {
            _RestaurantRegistrationService.Create(dto);
            return View();
        }
    }
}
