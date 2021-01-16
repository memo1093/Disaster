using disaster.business.Abstract;
using disaster.business.Concrete;
using disaster.data.Abstract;
using disaster.data.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace disaster.webui
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
            services.AddControllersWithViews();

            services.AddScoped<IDisasterRepository,EfCoreDisasterRepository>();
            services.AddScoped<ICityRepository,EfCoreCityRepository>();
            services.AddScoped<ITownRepository,EfCoreTownRepository>();

            services.AddScoped<IDisasterService,DisasterManager>();
            services.AddScoped<ICityService,CityManager>();
            services.AddScoped<ITownService,TownManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedDatabase.Seed();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "AddDisaster",
                    pattern: "disaster/add/",
                    defaults: new{Controller="Disaster",Action="CreateDisaster"});
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "EditDisaster",
                    pattern: "disaster/edit/{id}",
                    defaults: new{Controller="Disaster",Action="EditDisaster"});
            });
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
