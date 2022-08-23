using Delivery.Infrastructure.Services.MessageServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Delivery.Web.Areas.ControlPanel.Controllers
{
    public class MessageController : BaseController
    {
        private readonly IMessageService _message;

        public MessageController(IMessageService message)
        {
            _message = message; 
        }
        public async Task<IActionResult>  Index()
        {
        var Messages = await _message.GetAll();
          
            return View(Messages);
        }
    }
}
