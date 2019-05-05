using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeAddicts.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeAddicts
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration) => this.configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IAnimeRepository, AnimeRepository>();
            services.AddDbContext<AnimeContext>(cfg => cfg.UseSqlServer(configuration.GetConnectionString("AnimeConnection")));
            services.Configure<IISServerOptions>(options => { options.AutomaticAuthentication = true; });
            //Registering servie for application
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }
            //Middleware components used to hadling HTTP requests.

#if DEBUG
            app.UseDeveloperExceptionPage();    //yellow exception page
            app.UseStatusCodePages();   //200, 404 etc.
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();   //use only after useStaticFiles
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
#endif
        }
    }
}
