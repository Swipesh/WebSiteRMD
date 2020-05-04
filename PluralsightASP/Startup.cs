using System;
using GeekLearning.Storage;
using GeekLearning.Storage.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;
using PluralsightASP.Data;
namespace PluralsightASP
{
    public class Startup
    {
        private readonly IWebHostEnvironment _environment;

        public Startup(IConfiguration configuration,IWebHostEnvironment environment)
        {
            _environment = environment;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var migrationsAssembly = typeof(PluralsightAspDbContext).Namespace;
            services.AddDbContextPool<PluralsightAspDbContext>(options =>
                {
                    options.UseMySql(Configuration.GetConnectionString("MySql"));
                });

            services.AddStorage(Configuration.GetSection("Storage")).AddFileSystemStorage(_environment.ContentRootPath);

            services.Configure<StorageOptions>(Configuration.GetSection("Storage"));
            
            services.AddScoped<IEmailSender, EmailService>();
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<PluralsightAspDbContext>()
                .AddUserManager<UserManager>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
            
            services.AddAuthentication("cookies").AddCookie("cookies", options => options.LoginPath = "Account/Login");
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            //app.UseFileSystemStorageServer();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
        }
    }
}