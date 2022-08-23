using AutoMapper;
using Delivery.Core.Dtos;
using Delivery.Core.Dtos.ItemDtos;
using Delivery.Core.Dtos.ItemSizeDtos;
using Delivery.Core.Dtos.MenuDtos;
using Delivery.Core.Dtos.MessageDtos;
using Delivery.Core.Dtos.OpeningDtos;
using Delivery.Core.Dtos.OptionDtos;
using Delivery.Core.Dtos.RestaurantRegistrationDtos;
using Delivery.Core.Dtos.ResturantDtos;
using Delivery.Core.Dtos.RiderRegistrationDtos;
using Delivery.Core.ViewModels;
using Delivery.Data.Models;

namespace Delivery.Infrastructure.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Resturant, ResturantViewModel>().ForMember(x => x.CreatedAt, x => x.MapFrom(x => x.CreatedAt.ToString("yyyy:MM:dd")));
            CreateMap<CreateResturantDto, Resturant>();
            CreateMap<UpdateResturantDto, Resturant>();
            CreateMap<Resturant, UpdateResturantDto>();


            CreateMap<RestaurantRegistration, RestaurantRegistrationViewModel>().ForMember(x => x.CreatedAt, x => x.MapFrom(x => x.CreatedAt.ToString("yyyy:MM:dd")));
            CreateMap<RestaurantRegistrationDto, RestaurantRegistration>();

            CreateMap<RiderRegistration, RiderRegistrationViewModel>().ForMember(x => x.RiderGender, x => x.MapFrom(x => x.RiderGender.ToString()))
                .ForMember(x => x.vehicle, x => x.MapFrom(x => x.vehicle.ToString()));
            CreateMap<RiderRegistrationDto, RiderRegistration>().ForMember(x=>x.hearAboutUs,x=>x.MapFrom(x=>x.hearAboutUs.ToString()));


            CreateMap<Message, MessageViewModel>().ForMember(x => x.CreatedAt, x => x.MapFrom(x => x.CreatedAt.ToString("yyyy:MM:dd")));
            CreateMap<CreateMessageDto, Message>();

            CreateMap<Menu, MenuViewModel>();
            CreateMap<CreateMenuDto, Menu>();

            CreateMap<Item, ItemViewModel>();
            CreateMap<CreateItemDto, Item>();

            CreateMap<Opening, OpeningViewModel>();
            CreateMap<CreateOpeningDto, Opening>();

            CreateMap<ItemSize, ItemSizeViewModel>();
            CreateMap<CreateSizeDto, ItemSize>();

            CreateMap<Option, OptionViewModel>();
            CreateMap<CreateOptionDto, Option>();


        }
    }
}
