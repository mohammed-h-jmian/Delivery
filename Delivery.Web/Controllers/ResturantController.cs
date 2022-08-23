using Delivery.Infrastructure.Services;
using Delivery.Infrastructure.Services.RestaurantServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Delivery.Web.Controllers
{
    public class ResturantController : Controller
    {
        private readonly IResturantService _ResturantService;

        public ResturantController(IResturantService ResturantService)
        {
            _ResturantService = ResturantService;
        }
        public IActionResult Index()
        {
            var Resturants = _ResturantService.Get(2);

            return Ok(Resturants);
        }
        public async Task<IActionResult>  Detail(int id)
        {
            var Resturants = await _ResturantService.Get(id);

            return View(Resturants);
        }
    }
}
