using Delivery.Core.Dtos.MessageDtos;
using Delivery.Infrastructure.Services.MessageServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Delivery.Web.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService _message;
         public MessageController(IMessageService message)
        {
            _message = message; 
        }

        [HttpGet]
        public  IActionResult Create( )
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateMessageDto dto)
        {
            await _message.Create(dto);
            return View();
        }
    }
}
