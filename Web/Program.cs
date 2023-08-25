using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Models;

namespace Web
{
   public class Program
   {
      public static void Main(string[] args)
      {
         var builder = WebApplication.CreateBuilder(args);

         // Add services to the container.
         builder.Services.AddDbContext<DatabaseAccess>();
         builder.Services.AddControllersWithViews();

         builder.Services.Configure<RazorViewEngineOptions>(o =>
         {
            o.ViewLocationFormats.Add("/{0}" + RazorViewEngine.ViewExtension);
            o.ViewLocationFormats.Add("{0}" + RazorViewEngine.ViewExtension);
         });

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