using Delivery.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data
{
    public class DeliveryDbContext : IdentityDbContext
    {
        public DeliveryDbContext(DbContextOptions<DeliveryDbContext> options)
            : base(options)
        { }
        public DbSet<Category> categories { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<ItemSize> itemSizes { get; set; }
        public DbSet<Menu> menus { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Opening> openings { get; set; }
        public DbSet<Option> options { get; set; }
        public DbSet<Resturant> resturants { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<RestaurantRegistration> restaurantRegistrations { get; set; }
        public DbSet<RiderRegistration> riderRegistrations { get; set; }
    }

}

