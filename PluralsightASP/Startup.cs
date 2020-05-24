using System;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;
using LazZiya.ExpressLocalization;
using LazZiya.TagHelpers;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Razor.TagHelpers;
using PluralsightASP.Data;
using PluralsightASP.LocalizationResources;
using Microsoft.WindowsAzure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Azure;
using Microsoft.WindowsAzure.Storage.Blob;

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
            services.AddDbContextPool<PluralsightAspDbContext>(options =>
                {
                    options.UseMySql(Configuration.GetConnectionString("MySql"));
                });
            services.AddScoped<IEmailSender, EmailService>();
            services.AddIdentity<User, IdentityRole>( options =>
                {
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.User.RequireUniqueEmail = true;
                    //options.SignIn.RequireConfirmedEmail = true;
                })
                .AddEntityFrameworkStores<PluralsightAspDbContext>()
                .AddUserManager<UserManager>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
            services.AddSingleton<CloudBlobClient>(sp => { return CloudStorageAccount.Parse(Configuration.GetConnectionString("AccessKey")).CreateCloudBlobClient(); });
            services.AddAuthentication("cookies").AddCookie("cookies", options => options.LoginPath = "Areas/IdentityAccount/Login");
            var cultures = new[]
            {
                new CultureInfo("en"),
                new CultureInfo("ru")
            };
            services.AddRazorPages().AddExpressLocalization<ExpressLocalizationResource,ViewLocalizationResource>(ops =>
                {
                    ops.ResourcesPath = "LocalizationResources";
                    ops.RequestLocalizationOptions = o =>
                    {
                        o.SupportedCultures = cultures;
                        o.SupportedUICultures = cultures;
                        o.DefaultRequestCulture = new RequestCulture("ru");
                        o.SetDefaultCulture("ru");
                    };
                });
            
            services.AddTransient<ITagHelperComponent, LocalizationValidationScriptsTagHelperComponent>();
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
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseRequestLocalization();
            app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
        }
    }
}