using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace RashidCore.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //if we are developing web api, use AddControllers
            //services.AddControllers();

            //for working with razor pages use Add services.AddRazorPages();
            //services.AddRazorPages();

            //mor working on MVC Model (Model, Views and Controllers), use services.AddControllersWithViews();
            //services.AddControllersWithViews();

            //this is same as of AddControllersWithViews(), additionlay it uses the Page feature. if we really need Page feature, we will use AddMvc.
            //services.AddMvc();

            //#if DEBUG preprocessor will enable the runtime compilation only for dubug i.e. only for development environment
            #if DEBUG
            //enable run time compilation
            services.AddRazorPages().AddRazorRuntimeCompilation();
            #endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            //this method below will enable the static file from a specified folder outside wwwroot folder
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "MyImages")),
                RequestPath = "/MyImages"
            });

            //this method below will enable the static files from wwwroot folder
            app.UseStaticFiles();



            #region CODE TO TEST FLOW OF PIPELINE REQUEST/RESPONSE
            /* Below code is to test the flow of pipleline request/responses and use of next() method.
            //add a custom middleware
            app.Use(async (context,next)=> {
                await context.Response.WriteAsync("#.Book Store - first of first... ");
                await next();
                await context.Response.WriteAsync("#.Book Store - second of first... ");

            });
                       
            //add a custom middleware
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("#.Book Store - fist of second... ");
                await next();
                await context.Response.WriteAsync("#.Book Store - scond of second... ");
            });
            
            //add a custom middleware
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("#.Book Store - fist of third... ");
                await next();
                    });
            */
            #endregion

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});

                //MAKE SURE THAT THE ORDER OF MIDDLEWARES IS WRITTEN PROPERLY IN ORDER THEY NEED TO BE EXECUTED.
                //endpoints.MapGet method is used to map only the GET requests. we can also use .Map() method
                endpoints.MapGet("/rashid", async context =>
                {
                    await context.Response.WriteAsync("Hello Rashid!");
                });


                //endpoints.Map is used to map both the GET and the POST requests.
                endpoints.Map("/env", async context =>
                    {
                        //check/display the environment name set in launchSettings.json
                        // await context.Response.WriteAsync("Your working on : "+ env.EnvironmentName);

                        if (env.IsDevelopment())
                        {
                            await context.Response.WriteAsync("\nYou are in Development");
                        }
                        else if (env.IsStaging())
                        {
                            await context.Response.WriteAsync("\nYou are in Staging");
                        }
                        else if (env.IsProduction())
                        {
                            await context.Response.WriteAsync("\nYou are in Production");
                        }
                        else if (env.IsEnvironment("Testing"))//custom environment name
                        {
                            await context.Response.WriteAsync("\nYou are in Testing");
                        }
                        else
                        {
                            await context.Response.WriteAsync("\nUnknown/custom environment");
                        }
                    });


                //in order to use mvc, we have to tell application to use controllers
                // Summary:
                //     Adds endpoints for controller actions to the Microsoft.AspNetCore.Routing.IEndpointRouteBuilder
                //     and adds the default route {controller=Home}/{action=Index}/{id?}.
                //
                // Parameters:
                //   endpoints:
                //     The Microsoft.AspNetCore.Routing.IEndpointRouteBuilder.
                //
                // Returns:
                //     An Microsoft.AspNetCore.Builder.ControllerActionEndpointConventionBuilder for
                //     endpoints associated with controller actions for this route.

                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");


                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
