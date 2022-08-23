using AutoMapper;
using Delivery.Core.Dtos;
using Delivery.Core.Dtos.MessageDtos;
using Delivery.Core.ViewModels;
using Delivery.Data;
using Delivery.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Services.MessageServices
{
    public class MessageService : IMessageService
    {
        private readonly DeliveryDbContext _DB;
        private readonly IMapper _mapper;
       public MessageService(DeliveryDbContext DB , IMapper mapper)
        {
            _DB = DB;
            _mapper = mapper;
        }



        public async Task<string> Create(CreateMessageDto dto)
        {

            var message = _mapper.Map<Message>(dto);

            await _DB.messages.AddAsync(message);
            await _DB.SaveChangesAsync();

            return $"{message.MessageID}";
        }

        public async Task<List<MessageViewModel>> GetAll()
        {
            var MessageInDb =  _DB.messages
                .Where(x => !x.IsDelete).AsQueryable();

            var Messages = _mapper.Map<List<MessageViewModel>>(MessageInDb);

            // List<MessageViewModel> Messages = new List<MessageViewModel>() {};


            return Messages;

        }
    }
}
