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

            #region oidc security
            services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme) //Comment out this region, UseAuthentication() and UseAuthorization()
              .AddMicrosoftIdentityWebApp(configuration.GetSection("AzureAd"));    //to disable SSO. Make sure anonymous authentication is enabled in IIS.
            services.AddControllers(options =>                                     //We need to be using an ssl certificate for this to work right in chrome.
            {                                                                      //Configure URI redirects in portal.azure.com under App Registrations->
                var policy = new AuthorizationPolicyBuilder()                      //->RoadwayInventory->Authentication once authenticaion is enabled again 
                    .RequireAuthenticatedUser()                                    //Authorization seems to need a different registration method
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            //services.ConfigureNonBreakingSameSiteCookies();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("admin-only", p =>
                {
                    p.RequireClaim("groups", this.configuration["SystemInformationOID"]); //system information group object ID, should probably put GUID in appsettings
                    //portal.azure.com => App Registrations => RoadwayInventory => Manifest, then set "groupMembershipClaims": "SecurityGroup"
                    //portal.azure.com => Active Directory => find the group you want to allow => copy and paste the group's Object ID
                    //add the [Authorize("admin-only")] to classes/functions you want to require authorization
                });
            });

            services.AddRazorPages()
                .AddMicrosoftIdentityUI();
            #endregion


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


            // Add this before any other middleware that might write cookies
            app.UseCookiePolicy();
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
