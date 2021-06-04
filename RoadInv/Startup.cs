using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RoadInv.Models;
using Microsoft.Extensions.Configuration;
using RoadInv.DB;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Identity.Web.UI;
using Microsoft.AspNetCore.Http;

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
            
            services.AddMvc();

            services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
              .AddMicrosoftIdentityWebApp(configuration.GetSection("AzureAd")); //we need to be using an ssl certificate for this to work right in chrome
            services.AddControllers(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            //services.ConfigureNonBreakingSameSiteCookies();

            services.AddRazorPages()
                .AddMicrosoftIdentityUI();

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
                app.UseExceptionHandler("/Home/Error");
            }

            //app.Use((context, next) => //probably not necessary
            //{
            //    context.Request.Scheme = "http";
            //    return next();
            //});

            // Add this before any other middleware that might write cookies
            app.UseCookiePolicy();
            //app.UseCookiePolicy(new CookiePolicyOptions()
            //{
            //    MinimumSameSitePolicy = SameSiteMode.None
            //});
            app.UseFileServer();
            //app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();


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
