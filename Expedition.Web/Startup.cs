using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expedition.Web.DAL;
using Expedition.Web.DAL.Abstractions.DbContext;
using Expedition.Web.DAL.Abstractions.Repositories;
using Expedition.Web.DAL.DbContext;
using Expedition.Web.DAL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Expedition.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ExpeditionDbContex>(builder =>
            {
                var cs = Configuration["ConnectionString"];
                builder.UseSqlServer(cs);
            });
            services.AddScoped<IDbContextCommiter, DbContextCommiter>();
            services.AddScoped<IDbAccess, DbAccess>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
