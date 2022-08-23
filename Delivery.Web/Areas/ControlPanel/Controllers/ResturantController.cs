using Delivery.Core.Dtos.ResturantDtos;
using Delivery.Data;
using Delivery.Infrastructure.Services.RestaurantServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Delivery.Web.Areas.ControlPanel.Controllers
{
    public class ResturantController : BaseController
    {
        private readonly IResturantService _resturant;
        private readonly DeliveryDbContext _DB;
        public ResturantController(IResturantService resturant
            , DeliveryDbContext DB)
        {
            _resturant = resturant;
            _DB = DB;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Category = new SelectList( _DB.categories , "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(InterfaceResturantDto dto)
        {
            _resturant.Create(dto);
            return View();
        }



    }
}
