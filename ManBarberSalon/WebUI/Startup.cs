using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.EntitiyFramework.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Entities.Concrete.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using WebUI.ValidationRules.CustomValidations;

namespace WebUI
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

            services.AddSingleton<IEmployeeService, EmployeeManager>();
            services.AddSingleton<IEmployeeDal, EfEmployeeDal>();
            services.AddSingleton<IMenuService, MenuManager>();
            services.AddSingleton<IMenuDal, EfMenuDal>();
            services.AddSingleton<IReservationSerivce, ReservationManager>();
            services.AddSingleton<IReservationDal, EfReservationDal>();
            services.AddSingleton<ITimeService, TimeManager>();
            services.AddSingleton<ITimeDal, EfTimeDal>();
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(_ => _.UseSqlServer(Configuration["ConnectionStrings:SqlServerConnectionString"]));
            services.AddIdentity<AppUser, AppRole>(_ =>
                {
                    _.Password.RequiredLength = 5; 
                    _.Password.RequireNonAlphanumeric = false; 
                    _.Password.RequireLowercase = false; 
                    _.Password.RequireUppercase = false; 
                    _.Password.RequireDigit = false; 

                    _.User.RequireUniqueEmail = true; 
                    _.User.AllowedUserNameCharacters = "0123456789"; 
                }).AddPasswordValidator<CustomPasswordValidation>()
                .AddUserValidator<CustomUserValidation>()
                .AddErrorDescriber<CustomIdentityErrorDescriber>().AddEntityFrameworkStores<AppDbContext>();
            services.AddMvc();

            CookieBuilder cookieBuilder = new CookieBuilder();
            cookieBuilder.Name = "UserCookie";
            cookieBuilder.HttpOnly = false;
            cookieBuilder.SameSite = SameSiteMode.Lax;
            cookieBuilder.SecurePolicy = CookieSecurePolicy.SameAsRequest;

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/User/Login");
                options.LogoutPath = new PathString("/Home/Index");
                options.Cookie = cookieBuilder;
                options.SlidingExpiration = false;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(3);
            });

            services.AddAuthentication();

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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
