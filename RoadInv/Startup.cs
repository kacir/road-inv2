using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RoadInv.Models;
using Microsoft.Extensions.Configuration;
using RoadInv.DB;
using Microsoft.EntityFrameworkCore;
using System;

namespace RoadInv
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc();

            //services.AddSession(options => 
            //{
            //    options.IdleTimeout = TimeSpan.FromMinutes(30); //sets session expire time
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.IsEssential = true;
            //});

            //both entity framework and SQL Client are needed for project
            //used for entity framework database connection
            services.AddDbContext<roadinvContext>
                (options => options.UseSqlServer(this.configuration["EntityConnectinString"]));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            } else
            {
                app.UseExceptionHandler("error");
            }

            app.UseFileServer();
            app.UseRouting();
            //app.UseSession();
            

            app.UseEndpoints(endpoints => 
            {
               endpoints.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home}/{action=Index}/{id?}");

               endpoints.MapControllers();
            });
        }
    }
}
