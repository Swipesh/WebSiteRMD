using System;
using System.Globalization;
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
using LazZiya.ExpressLocalization;
using LazZiya.TagHelpers;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Razor.TagHelpers;
using PluralsightASP.Data;
using PluralsightASP.LocalizationResources;

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
            
            services.AddAuthentication("cookies").AddCookie("cookies", options => options.LoginPath = "Areas/IdentityAccount/Login");
            var cultures = new[]
            {
                new CultureInfo("ru"),
                new CultureInfo("en"),
            };
            services.AddRazorPages().AddExpressLocalization<ExpressLocalizationResource,ViewLocalizationResource>(ops =>
                {
                    ops.ResourcesPath = "LocalizationResources";
                    ops.RequestLocalizationOptions = o =>
                    {
                        o.SupportedCultures = cultures;
                        o.SupportedUICultures = cultures;
                        o.DefaultRequestCulture = new RequestCulture("ru");
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

            app.UseRequestLocalization();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
        }
    }
}