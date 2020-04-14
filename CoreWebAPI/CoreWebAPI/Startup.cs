using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebAPI.Models;
using CoreWebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreWebAPI
{
    //**** Multiple Startup Class are allowed, preference given to the one
    //with environment name as suffix ****
    public class Startup
    {
        private IConfiguration config;

        public Startup(IConfiguration config)
        {
            this.config = config;
        }

        // Called at runtime. Used to add services.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("EmployeeDbConnection")));

            //***** MVC Pipeline & Compatibility Version(using Microsoft.AspNetCore.Mvc;) *****
            services.AddMvc();//.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //services.AddSingleton<IEmployeeService, EmployeeService>();
            services.AddSingleton<IEmployeeService, SqlEmployeeService>();
        }

        // Called at runtime. Configures HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // ****** To ensure HTTPS is used and not HTTP ********
                app.UseHsts();
            }
            //**** Redirects HTTP to HTTPS ****
            app.UseHttpsRedirection();

            //**** To use MVC, there's also UseMvcWithDefaultRoute
            app.UseMvc();
        }
    }
}
