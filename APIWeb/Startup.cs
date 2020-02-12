using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace APIWeb
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            IProPublicaService congressService = new ProPublicaService(Configuration["Configurations:ProPublicEndpoint"], Configuration["Configurations:ProPublicaAPIKey"]);
            services.AddSingleton(congressService);

            IGoogleGeocodeService geocodeService = new GoogleGeocodeService(Configuration["Configurations:GoogleGeocodeEndpoint"], Configuration["Configurations:GoogleApiKey"]);
            services.AddSingleton(geocodeService);

            IDarkSkyService darkSkyService = new DarkSkyService(Configuration["Configurations:DarkSkyEndpoint"], Configuration["Configurations:DarkSkySecretKey"]);
            services.AddSingleton(darkSkyService);
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
