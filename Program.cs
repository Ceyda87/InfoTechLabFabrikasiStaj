using InfoTechLabProjeFabrikasi.Code;
using InfoTechLabProjeFabrikasi.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace InfoTechLabProjeFabrikasi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var constr = builder.Configuration.GetConnectionString("PlatformSqlCon");

            // Add services to the container.
            builder.Services.AddTransient<IListService, ListService>();            
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<InfoTechLabContext>(
                options=>options.UseSqlServer(constr));
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}