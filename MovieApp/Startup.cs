using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp
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
            //services.AddMvc();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseStaticFiles();   //   wwwroot klas�r�n� d��ar� a�ar. Fakat wwwroot d���nda bir dosyay� d��ar� a�mak i�in  =>
                                    //   /css/style.css veya /img/1.jpg �eklinde uzant� kullanaca��z.

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "lib")),
                RequestPath = "/modules"   //Burda ki modules asl�nda takma isim yani /lib in yerine bir isim                                         
                                           //  lib/bootstrap/dist/css/bootstrap.min.css
            });
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                //app.Run(async (context) =>
                //{
                //    await context.Response.WriteAsync("Hello World!"); // Kullan�c�y� istedi�imiz bir sayfaya y�nlendirmek i�in kullan�r�z

                //});
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");  // Bu alanlar� defaultta a��ld���nda nereye y�nlenmesini istiyorsak ona g�re ayarl�yoruz
            });


        }
    }
}
