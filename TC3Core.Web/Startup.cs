using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TC3Core.Data;
using TC3Core.Services;

namespace TC3Core
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
            .AddOpenIdConnect(options =>
            {
                Configuration.Bind("AzureAd", options);
            })
            .AddCookie();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //services.AddSingleton<IRestaurantData, MemoryRestaurantData>();
            services.AddDbContext<TCContext>();
            services.AddScoped<IBookData, SqlBookData>();
            services.AddScoped<IDecalData, SqlDecalData>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            #region "Sample Pipeline Middleware"
#if EnableCustomMiddleware
            //Configure a custom middleware component...
            app.Use(next =>
            {
                return async context =>
                {
                    logger.LogInformation("Request incoming");
                    if (context.Request.Path.StartsWithSegments("/mym"))
                    {
                        await context.Response.WriteAsync("Hit!!");
                        logger.LogInformation("Request handled");
                    }
                    else
                    {
                        await next(context);
                        logger.LogInformation("Request outgoing");
                    };
                };
            });
#endif
#if EnableWelcomePage
            //Enable WelcomePage (conditional on /wp)...
            app.UseWelcomePage(new WelcomePageOptions
            {
                Path = "/wp"
            });
#endif
#if EnableFileServer
            //Enable conditional directory browsing along with Default/StaticFiles...
            app.UseFileServer();
#endif
#if EnableDefaultFiles
            //Enable DefaultFiles and StaticFiles...
            app.UseDefaultFiles();
            app.UseStaticFiles();
#endif
            #endregion

            //Force use of SSL...
            app.UseRewriter(new RewriteOptions().AddRedirectToHttpsPermanent());

            app.UseHttpsRedirection();

            //Enable direct-hit StaticFiles (no default file handling) from wwwroot...
            app.UseStaticFiles();
            app.UseNodeModules(env.ContentRootPath);

            //Enable Azure Active Directory Authentication...
            app.UseAuthentication();

            //Enable MVC with default conventional routing...
            //app.UseMvcWithDefaultRoute();

            //Enable MVC with mapped routing...
            app.UseMvc(ConfigureRoutes);

            //app.Run(async (context) =>
            //{
            //    var greeting = greeter.GetMessageOfTheDay();
            //    //throw new Exception("error!");
            //    context.Response.ContentType = "text/plain";
            //    await context.Response.WriteAsync($"{greeting} : {env.EnvironmentName}");
            //});
            app.UseCookiePolicy();
        }
        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            // / or /Home or /Home/Index or /Home/Index/4
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
