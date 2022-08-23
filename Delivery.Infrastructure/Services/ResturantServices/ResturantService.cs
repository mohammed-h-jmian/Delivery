using AutoMapper;
using Delivery.Core.Dtos.ResturantDtos;
using Delivery.Core.ViewModels;
using Delivery.Data;
using Delivery.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Services.RestaurantServices
{
    public class ResturantService : IResturantService
    {
        private readonly DeliveryDbContext _DB;
        private readonly IMapper _mapper;
        public ResturantService(DeliveryDbContext DB
            , IMapper mapper)
        {
            _DB = DB;
            _mapper = mapper;
        }

        public async Task<string> Create(InterfaceResturantDto dto)
        {
            var opening = _mapper.Map<Opening>(dto.opening);

             _DB.openings.Add(opening);
            await _DB.SaveChangesAsync();


            var resturant = _mapper.Map<Resturant>(dto.Resturant);
            resturant.OpeningID = opening.OpeningID;
             _DB.resturants.Add(resturant);
            await _DB.SaveChangesAsync();



            var menu = _mapper.Map<Menu>(dto.Menu);
            menu.ResturantID= resturant.ResturantID;
             _DB.menus.Add(menu);
            await _DB.SaveChangesAsync();



            var item = _mapper.Map<Item>(dto.Item);
            item.MenuID = menu.MenuID;
             _DB.items.Add(item);
            await _DB.SaveChangesAsync();


            var option = _mapper.Map<Option>(dto.Option);
            option.ItemID = item.ItemID;
             _DB.options.Add(option);
            await _DB.SaveChangesAsync();

            var size= _mapper.Map<ItemSize>(dto.Size);
            size.ItemID = item.ItemID;

             _DB.itemSizes.Add(size);
            await _DB.SaveChangesAsync();



            return $"{resturant.ResturantID}";
        }

        //public List<ResturantViewModel> GetAll()
        //{
        //    //var AllResturant = _DB.resturants.Select(x => new ResturantViewModel()
        //    //{
        //    //    ResturantID = x.ResturantID,
        //    //    ResturantTitle = x.ResturantTitle,
        //    //    Email = x.Email,
        //    //    Facebook = x.Facebook,
        //    //    GooglePluse = x.GooglePluse,
        //    //    ImgURl = x.ImgURl,
        //    //    Phone = x.Phone,
        //    //    Twitter = x.Twitter,
        //    //    Website = x.Website,
        //    //    ResturantDescriptoin = x.ResturantDescriptoin,
        //    //    ResturantKeywords = x.ResturantKeywords,
        //    //    //ResturantType = x.ResturantType.ToString(),
        //    //    category = new CategoryViewModel()
        //    //    {
        //    //        CategoryID = x.CategoryID,
        //    //        CategoryName = x.category.CategoryName
        //    //    },
        //    //    CreatedAt = x.CreatedAt,
        //    //    opening = new OpeningViewModel()
        //    //    {
        //    //        OpeningID = x.opening.OpeningID,
        //    //        MondayOpen = x.opening.MondayOpen,
        //    //        MondayClose = x.opening.MondayClose,
        //    //        ThursdayOpen = x.opening.ThursdayOpen,
        //    //        ThursdayClose = x.opening.ThursdayClose,
        //    //        TuesdayOpen = x.opening.TuesdayOpen,
        //    //        TuesdayClose = x.opening.TuesdayClose,
        //    //        WednesdayOpen = x.opening.WednesdayOpen,
        //    //        WednesdayClose = x.opening.WednesdayClose
        //    //    },
        //    //    //Menus = new MenuViewModel()
        //    //    //{
        //    //    //    MenuID = x.menus

        //    //    //}


        //    //}).ToList();
        //    var AllResturant = _DB.resturants
        //        .Include(x=>x.category)
        //        .Include(x=>x.opening).Where(x=> !x.IsDelete).ToList();

        //    var Result = _mapper.Map<List<ResturantViewModel>>(AllResturant);



        //    return Result ;
        //}
        public  async Task<ResturantViewModel> Get(int id)
        {

            var resturant = await _DB.resturants.FirstOrDefaultAsync(x=>x.ResturantID ==id && !x.IsDelete );

            var result = _mapper.Map<ResturantViewModel>(resturant);


            return result;

        }


    }
}
