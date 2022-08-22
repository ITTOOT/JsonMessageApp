using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JsonMessageApi.Context;
using Microsoft.AspNetCore.Http;
using JsonMessageApi.Models;
using JsonMessageApp.Config;
//using AutoMapper.Mappers;

namespace JsonMessageApi
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _configuration;

        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            _env = env;
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Specifies that the database context will use an in-memory database.
            services.AddDbContext<DataContext>();

            // API middleware, registers all controllers (classes that derive from ControllerBase).
            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.IgnoreNullValues = true;
                    options.JsonSerializerOptions.WriteIndented = true;
                });
                

            // Auto mapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Adds the settings object as injectable IOptions into the constructor of any class that needs them.
            services.Configure<AppSettings>(_configuration.GetSection("AppSettings"));

            // Manually register IHttpContextAccessor as a service 
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DataContext dataContext)
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Added
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // Endpoints
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
