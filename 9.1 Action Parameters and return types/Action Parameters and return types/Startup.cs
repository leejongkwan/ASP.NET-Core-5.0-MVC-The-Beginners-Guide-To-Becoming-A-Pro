using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SampleApplication
{

    /// <summary>
    /// Constructor which injects IConfiguration.
    /// </summary>
    /// <param name="configuration"></param>
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //Configuration is used to get al the configuration level properties and methods.
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //this adds the MVC Controller services that are common to both Web API and MVC and also the services required to run razor views.
            services.AddControllersWithViews();
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
            //Enable static file serving for the request. (its added by default)
            app.UseStaticFiles();

            //middle ware to enable routing. (its added by default)
            app.UseRouting();

            //to enable autorization capabilities. (its added by default)
            app.UseAuthorization();

            //below code specifies the default routing or we can say default page for the application, here its Home/index
            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
