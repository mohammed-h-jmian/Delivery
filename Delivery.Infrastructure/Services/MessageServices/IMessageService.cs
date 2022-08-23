using Delivery.Core.Dtos;
using Delivery.Core.Dtos.MessageDtos;
using Delivery.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Services.MessageServices
{
    public interface IMessageService
    {
        Task<List<MessageViewModel>> GetAll();
        Task<string> Create(CreateMessageDto dto);
    }
}
