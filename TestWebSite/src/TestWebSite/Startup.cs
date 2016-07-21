using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace TestWebSite
{
    public class Startup
    {

        public static Assembly[] AdditionalAssemblies;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc().AddRazorOptions(x => {
                x.FileProviders.Add(new EmbeddedFileProvider(typeof(Components.UI.HtmlHead).GetTypeInfo().Assembly));
                x.FileProviders.Add(new EmbeddedFileProvider(typeof(Components.UI.Tile).GetTypeInfo().Assembly));
                x.FileProviders.Add(new EmbeddedFileProvider(typeof(Components.UI.Layout).GetTypeInfo().Assembly));
                x.FileProviders.Add(new EmbeddedFileProvider(typeof(Components.UI.Navigation).GetTypeInfo().Assembly));
                x.ViewLocationExpanders.Add(new ThemeEngine());
            });

            
            //Get Data Services
            services.AddTransient<Data.IPerson, Data.Person>();
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new EmbeddedFileProvider(typeof(Components.UI.Tile).GetTypeInfo().Assembly),
                RequestPath = new PathString("/Component.Tile")
            });

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new EmbeddedFileProvider(typeof(Components.UI.Layout).GetTypeInfo().Assembly),
                RequestPath = new PathString("/Component.Layout")
            });


            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
               
    }




}
