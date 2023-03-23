using Serilog;

namespace StudyWithPatron
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseSerilogRequestLogging();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddMvc();
        //}

        //public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        //app.UseBrowserLink();
        //        app.UseDirectoryBrowser();
        //        app.UseDeveloperExceptionPage();
        //    }
        //    else
        //    {
        //        app.UseExceptionHandler("/Home/Error");
        //    }
        //    app.UseStaticFiles();

        //    //app.UseMvc(routes =>
        //    //{
        //    //    routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index)/{id?}");

        //    //});
        //}
    }
}
