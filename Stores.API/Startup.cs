using Autofac;
using MassTransit;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Stores.API.Application.IntegrationEvent.Event;
using Stores.API.Infrastructure.AutofacModules;
using Stores.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Stores.API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Stores.API", Version = "v1" });
            });

            services.AddDbContext<StoreContext>(options =>
                                 options.UseMySql(Configuration.GetConnectionString("StoresConnectionString"),
                                 new MySqlServerVersion("8.0.22"), b => b.MigrationsAssembly("Product.API")));

            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(typeof(Startup));

            services.AddMassTransit(options =>
            {
                options.AddConsumer<ProductMessageConsumer>();

                options.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(c =>
                {
                    c.Host("rabbitmq://localhost", h =>
                    {
                        h.Username("guest");
                        h.Password("guest");
                    });

                    c.ConfigureEndpoints(provider);

                    c.ReceiveEndpoint("productQueue", ep =>
                    {
                        ep.ConfigureConsumer<ProductMessageConsumer>(provider);
                    });
                }));
            });

            services.AddMassTransitHostedService();
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            //  builder.RegisterModule(new DatabaseModule(Configuration.GetConnectionString("ProductConnectionString")));
            builder.RegisterModule(new StoreModules());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Stores.API v1"));
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

    public class BusConstants
    {
        public const string RabbitMqUri = "rabbitmq://localhost/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string QueueName = "validate-order-queue";
    }
}
