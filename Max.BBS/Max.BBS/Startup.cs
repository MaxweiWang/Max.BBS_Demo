﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Max.Infrastructure;
using Microsoft.EntityFrameworkCore;
using NLog.Extensions.Logging;
using Max.MBBS.Middleware;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.WebEncoders;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using Max.ApplicationCore.Entities;
using Max.Infrastructure.Repositorys;
using Max.ApplicationCore.Interfaces;

namespace Max.MBBS
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
            services.AddDbContext<DataContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password = new PasswordOptions() {
                    RequireNonAlphanumeric = false,
                    RequireUppercase=false
                };
            }).AddEntityFrameworkStores<DataContext>().AddDefaultTokenProviders();
            // Add framework services.
            services.AddMvc(option=> {
                option.EnableEndpointRouting = false;
            });
            services.AddScoped<IRepository<TopicNode>, Repository<TopicNode>>();
            services.AddScoped<ITopicRepository, TopicRepository>();
            services.AddScoped<ITopicReplyRepository, TopicReplyRepository>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<UserServices>();
            services.AddMemoryCache();
            services.AddAuthorization(options =>
            {
                options.AddPolicy(
                    "Admin",
                    authBuilder =>
                    {
                        authBuilder.RequireClaim("Admin", "Allowed");
                    });
            });
            //文字被编码 https://github.com/aspnet/HttpAbstractions/issues/315
            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseRequestIPMiddleware();

            InitializeMaxBBSDatabase(app.ApplicationServices);
            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseStatusCodePages();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areaRoute",
                    template: "{area:exists}/{controller}/{action}",
                    defaults: new { action = "Index" });
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        /// <summary>
        /// 生成数据库
        /// </summary>
        /// <param name="serviceProvider"></param>
        private void InitializeMaxBBSDatabase(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<DataContext>();
                db.Database.Migrate();
                if (db.TopicNodes.Count() == 0)
                {
                    db.TopicNodes.AddRange(GetTopicNodes());
                    db.SaveChanges();
                }
            }
        }

        IEnumerable<TopicNode> GetTopicNodes()
        {
            return new List<TopicNode>()
            {
                new TopicNode() { Name=".NET Core", NodeName="", ParentId=0, Order=1, CreateOn=DateTime.Now, },
                new TopicNode() { Name=".NET Core", NodeName="netcore", ParentId=1, Order=1, CreateOn=DateTime.Now, },
                new TopicNode() { Name="ASP.NET Core", NodeName="aspnetcore", ParentId=1, Order=1, CreateOn=DateTime.Now, }
            };
        }
    }
}
