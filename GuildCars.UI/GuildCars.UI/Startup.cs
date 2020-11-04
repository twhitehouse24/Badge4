using GuildCars.UI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Newtonsoft.Json.Serialization;
using Owin;
using System;
using System.Net.Http.Formatting;
using System.Web.Http;

[assembly: OwinStartupAttribute(typeof(GuildCars.UI.Startup))]
namespace GuildCars.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            {
                HttpConfiguration httpConfig = new HttpConfiguration();

                //ConfigureOAuthTokenGeneration(app);

                //ConfigureWebApi(httpConfig);

                app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

                app.UseWebApi(httpConfig);

            }

            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    // Enables the application to validate the security stamp when the user logs in.
                    // This is a security feature which is used when you change a password or add an external login to your account.  
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
             validateInterval: TimeSpan.FromMinutes(30),
             regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });

            //private void ConfigureOAuthTokenGeneration(IAppBuilder app)
            //{
            //    // Configure the db context and user manager to use a single instance per request
            //    app.CreatePerOwinContext(ApplicationDbContext.Create);
            //    app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            //    // Plugin the OAuth bearer JSON Web Token tokens generation and Consumption will be here

            //}

            //private void ConfigureWebApi(HttpConfiguration config)
            //{
            //    config.MapHttpAttributeRoutes();

            //    var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            //    jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //}
        }
    }
}
