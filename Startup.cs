﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace reportApp
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
           services.Configure<IISOptions>(options =>
           {
               options.ForwardClientCertificate = false;

           });


            services.AddAuthentication(IISDefaults.AuthenticationScheme);
            services.AddAuthorization();
            services.AddSingleton<IAppAuthorizationService, reportApp.AppAuthorizationService>();
            services.AddSingleton<IAuthorizationHandler, IsAdminHandler>();
            services.AddSingleton<IAuthorizationHandler, IsSalesPersonHandler>();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("IsSalesPersonRequirement", policyIsSalesPersonRequirement =>
                {
                    policyIsSalesPersonRequirement.Requirements.Add(new IsSalesPersonRequirement());
                });
                options.AddPolicy("IsAdminRequirement", policyIsAdminRequirement =>
                {
                    policyIsAdminRequirement.Requirements.Add(new IsAdminRequirement());
                });

            });

            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStatusCodePages(async context => {
                var response = context.HttpContext.Response;

                if (response.StatusCode == (int)HttpStatusCode.Unauthorized ||
                    response.StatusCode == (int)HttpStatusCode.Forbidden)
                {
                    response.Redirect("/Home/NotAuthorized");
                }
            });
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=SalesReportInterface}/{action=SelectParam}");
            });

        }
    }
}
