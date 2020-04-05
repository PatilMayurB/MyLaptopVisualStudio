using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement
{
    // 13. Exception Page
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello Hello");
            });
        }
    }
}



//{
//    // 13. Exception Page
//    public class Startup
//    {
//        // This method gets called by the runtime. Use this method to add services to the container.
//        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
//        public void ConfigureServices(IServiceCollection services)
//        {
//        }

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                DeveloperExceptionPageOptions options = new DeveloperExceptionPageOptions
//                {
//                    SourceCodeLineCount = 10
//                };
//                app.UseDeveloperExceptionPage(options);
//            }
//            app.UseFileServer();

//            app.Run(async (context) =>
//            {
//                throw new Exception("Exception");
//                //await context.Response.WriteAsync("mw3");
//            });
//        }
//    }
//}

// 12. //Accessing Static and Default Files
//{
//    public class Startup
//    {
//        // This method gets called by the runtime. Use this method to add services to the container.
//        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
//        public void ConfigureServices(IServiceCollection services)
//        {
//        }

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }

//            //To access default pages
//            //app.UseDefaultFiles();
//            //app.UseStaticFiles();

//            //To access custom default pages
//            //DefaultFilesOptions customDefault = new DefaultFilesOptions();
//            //customDefault.DefaultFileNames.Clear();
//            //customDefault.DefaultFileNames.Add("firstpage.html");
//            //app.UseDefaultFiles(customDefault);
//            //app.UseStaticFiles();

//            //FileServerOptions
//            //FileServerOptions customDefault = new FileServerOptions();
//            //customDefault.DefaultFilesOptions.DefaultFileNames.Clear();
//            //customDefault.DefaultFilesOptions.DefaultFileNames.Add("firstpage.html");
//            //app.UseFileServer(customDefault);



//            app.Run(async (context) =>
//            {
//                await context.Response.WriteAsync("mw3");
//            });
//        }
//    }
//}


//Test
//
//namespace EmployeeManagement
//{
//    public class Startup
//    {
//        private IConfiguration _config;

//        public Startup(IConfiguration config)
//        {
//            _config = config;
//        }

//        // This method gets called by the runtime. Use this method to add services to the container.
//        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
//        public void ConfigureServices(IServiceCollection services)
//        {
//        }

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
//                               ILogger<Startup> logger)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }

//            //app.Run(async (context) =>
//            //To call next middleware
//            app.Use(async (context, next) =>
//            {
//                //await context.Response.WriteAsync("1st Hello World!");
//                logger.LogInformation("Middleware(mw) 1 request");
//                await next();
//                logger.LogInformation("mw1 1 response");
//            });
//            app.Use(async (context, next) =>
//            {
//                //await context.Response.WriteAsync("1st Hello World!");
//                logger.LogInformation("mw2 request");
//                await next();
//                logger.LogInformation("mw2 response");
//            });
//            app.Run(async (context) =>
//            {
//                await context.Response.WriteAsync("mw3");
//                logger.LogInformation("mw3 request & response");
//            });
//        }
//    }
//}

