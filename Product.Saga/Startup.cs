using MassTransit;
using MassTransit.Definition;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Product.Saga.StateMachine;
using MassTransit.Saga;

namespace Product.Saga
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton(KebabCaseEndpointNameFormatter.Instance);

            var saga = new ProductStateMachine();
            var repo = new InMemorySagaRepository<ProductStateData>();

            services.AddMassTransit(options =>
            {
                options.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(c =>
                {
                    c.Host("rabbitmq://localhost", h =>
                    {
                        h.Username("guest");
                        h.Password("guest");

                        c.ReceiveEndpoint(BusConstants.SagaQueue, e =>
                        {
                            e.StateMachineSaga(saga, repo);
                        });
                    });

                    c.ConfigureEndpoints(provider);
                }));
            });

            //http://localhost:15672 this is for rabbitmq

            services.AddMassTransitHostedService();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
    public class BusConstants
    {
        public const string RabbitMqUri = "rabbitmq://localhost/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string SagaQueue = "saga-bus-queue";
    }

}
