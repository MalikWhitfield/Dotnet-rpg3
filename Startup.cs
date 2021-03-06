using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Dotnet_rpg3.Services.Meet;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Dotnet_rpg3.Services.CharacterService;
using Dotnet_rpg3.Services.AthleteService;
using AutoMapper;
using Dotnet_rpg3.Services.PracticeResultService;
using Dotnet_rpg3.Data;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_rpg3
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
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Dotnet_rpg3", Version = "v1" });
            });
            services.AddScoped<ICharacterService, CharacterService>();
            services.AddScoped<IAthleteService, AthleteService>();
            services.AddScoped<IPracticeResultService, PracticeResultService>();
            services.AddScoped<IMeetResultService, MeetResultService>();
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IAuthRepository, AuthRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dotnet_rpg3 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
