using Delivery.Data;
using Delivery.Infrastructure.AutoMapper;
using Delivery.Infrastructure.Services.MessageServices;
using Delivery.Infrastructure.Services.RestaurantRegistrationServices;
using Delivery.Infrastructure.Services.RestaurantServices;
using Delivery.Infrastructure.Services.RiderRegistrationServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Delivery.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DeliveryDbContext>(options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<DeliveryDbContext>()
                //.AddDefaultUI()
                .AddDefaultTokenProviders();


            services.AddRazorPages();

            //services.AddAutoMapper(typeof(Startup));

            services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            // services
            services.AddScoped<IResturantService, ResturantService>();
            services.AddScoped<IRestaurantRegistrationService, RestaurantRegistrationService>();
            services.AddScoped<IRiderRegistrationService, RiderRegistrationService>();
            services.AddScoped<IMessageService, MessageService>();


            services.AddAutoMapper(typeof(MapperProfile).Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                         name: "ControlPanel",
                          pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                        );
                endpoints.MapControllerRoute(
                    name: "default",
                 pattern: "{controller=Home}/{action=Index}/{id?}");
                //pattern: "{Area=ControlPanel}/{controller=Home}/{action=Index}");

                endpoints.MapRazorPages();


            });
        }
    }
}
