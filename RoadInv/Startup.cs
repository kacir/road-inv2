using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RoadInv.Models;
using Microsoft.Extensions.Configuration;
using RoadInv.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Web;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Identity.Web.UI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using System.IdentityModel.Tokens.Jwt;

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

            #region Authentication and Authorization
            //Authentication and Authorization using Azure AD
            services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme) //Comment out this region, UseAuthentication() and UseAuthorization()
              .AddMicrosoftIdentityWebApp(configuration.GetSection("AzureAd"));    //to disable SSO. Make sure anonymous authentication is enabled in IIS.
            services.AddControllers(options =>                                     //We need to be using an ssl certificate for this to work right in chrome.
            {                                                                      //Configure URI redirects in portal.azure.com under App Registrations->
                var policy = new AuthorizationPolicyBuilder()                      //->RoadwayInventory->Authentication once authenticaion is enabled again 
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            //services.ConfigureNonBreakingSameSiteCookies();

            services.AddAuthorization(options =>
            {
                //options.AddPolicy(AuthorizationPolicy.AssignmentToUserReaderRoleRequired, policy => policy.RequireRole(AppRole.UserReaders));
                options.AddPolicy("admin-only", p =>
                {
                    /*To implement, go to portal.azure.com
                     * => App Registrations
                     * => RoadwayInventory
                     * => Manifest, then set "groupMembershipClaims" to SecurityGroup
                     * To find groups to add, to to portal.azure.com
                     * => Active Directory
                     * => Groups, find the group you want to allow, click and copy/paste the group's object ID
                     * Add the [Authorize("admin-only")] attribute to classes/functions you want to require authorization
                     * When decorating classes/actions with the [Authorize(Roles="")], need to remember that
                     * => we are using the role's Value attribute in the Azure AD app Manifest and not the displayName
                      Also, make sure authentication is set to 'Allow Anonymous'*/

                    p.RequireAssertion(context =>
                        context.User.HasClaim(c =>
                            c.Value == this.configuration["TrafficInformationSys"] ||  //system information and research - traffic information systems
                            c.Value == this.configuration["SystemInformation"] ||      //system information and research - system information
                            c.Value == this.configuration["TrafficInformation"] ||     //system information and research - traffic information
                            c.Value == this.configuration["SystemInfoGIS"] ||          //system information and research - gis
                            c.Value == this.configuration["TrafficDataCollection"] ||  //system information and research - traffic data collection
                            c.Value == this.configuration["ITSecurity"]                
                            )
                        );
                    //p.RequireAssertion(context =>
                    //{
                    //    string strUserId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    //    var user = await userManager.FindByIdAsync(strUserId);
                    //    string[] roles = (await userManager.GetRolesAsync(user)).ToArray();
                    //    return roles.Contains("Admin");
                    //};

                    //p.RequireUserName(configuration.GetSection("User0").Value);     //can set policy to only allow specific users
                    //p.RequireUserName(configuration.GetSection("User1").Value);      //configured in appsettings.json
                    
            });

                //options.AddPolicy("super-user0", p => { p.RequireUserName(configuration.GetSection("User0").Value); }); //individual users
                //options.AddPolicy("super-user1", p => { p.RequireUserName(configuration.GetSection("User1").Value); });

            });
            
            #endregion

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


            // Add this before any other middleware that might write cookies
            app.UseCookiePolicy();
            app.UseFileServer();
            app.UseHttpsRedirection();
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
