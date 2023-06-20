using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Project_Flying_BackEnd.Models;
using Project_Flying_BackEnd.Repository;
using Project_Flying_BackEnd.Service;

namespace Project_Flying_BackEnd
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IuserRepository<Users>, UserRepository>();
            services.AddSingleton<IuserService<Users>, UsersService>();
            services.AddSingleton<IairoportRepository<Airport>, AiroportRepository>();

            services.AddSingleton<IairportService<Airport>, AirportService>();
            services.AddSingleton<IflightRepository<Flight>, FlightRepository>();
            services.AddSingleton<IflightService<Flight>, FlightService>();
            services.AddSingleton<IuserFlightRepository<UsersFlight>,UserFlightsRepository>();
            services.AddSingleton<IusersFlightsService<UsersFlight>, UsersFlightsService>();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.WithOrigins("*").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            });
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseCors("AllowOrigin");
        }
    }
}
