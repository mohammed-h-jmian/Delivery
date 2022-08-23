using Microsoft.AspNetCore.Mvc;

namespace Delivery.Web.Areas.ControlPanel.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
