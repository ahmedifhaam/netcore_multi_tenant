using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Test1.Contexts.Client;
using Test1.Contexts.System;
using Test1.MapperProfile;
using Test1.Repositories.Client;
using Test1.Repositories.System;

namespace Test1
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

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new SystemProfile());
            });
            
            //IMapper mapper = mappingConfig.CreateMapper();
            services.AddDbContext<SystemDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SystemDb"));
            });
            ////services.AddDbContext<DatabaseContext>(options =>
            ////{
            ////    options.UseSqlServer(Configuration.GetConnectionString("clienttwo"));
            ////});
            ///

            services.AddSingleton < MapperConfiguration>(mappingConfig);
            services.AddSingleton<DatabaseContextFactory>();
            services.AddScoped<ISystemRepository, SystemRepository>();
            services.AddScoped<IBranchRepository,BranchRepository>();
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
