using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Product.Domain.AggregateModel.ProductAggregate;
using Product.Infrastructure;
using Product.Infrastructure.Repositories;
using MediatR;
using System.Reflection;
using FluentValidation;
using Serilog;
using Serilog.Events;
using Autofac;
using Product.API.Infrastructure.AutofacModules;
using Autofac.Extensions.DependencyInjection;

Log.Logger = new LoggerConfiguration()
                  .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                  .Enrich.FromLogContext()
                  .WriteTo.Console()
                  .CreateBootstrapLogger();
try
{
    Log.Information("Starting Product service");

    var builder = WebApplication.CreateBuilder(args);

    //builder.Host.UseSerilog((context, services, configuration) => configuration
     //             .ReadFrom.Configuration(context.Configuration)
     //             .ReadFrom.Services(services)
       //           .Enrich.FromLogContext());

    builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(ConfigureContainer));
    static void ConfigureContainer(ContainerBuilder builder)
    {
        //  builder.RegisterModule(new DatabaseModule(Configuration.GetConnectionString("ProductConnectionString")));
        builder.RegisterModule(new DatabaseModule());
    }


    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProductService", Version = "v1" });
    });

    builder.Services.AddDbContext<ProductContext>(options =>
                                     options.UseNpgsql(builder.Configuration.GetConnectionString("ProductConnectionString"),
                                      b => b.MigrationsAssembly("Product.API")));

    builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
    builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
    builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

    builder.Services.AddMassTransit(options =>
    {
        options.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(c =>
        {
            c.Host("rabbitmq://localhost", h =>
            {
                h.Username("guest");
                h.Password("guest");
            });

            c.ConfigureEndpoints(provider);
        }));
    });

    //http://localhost:15672 this is for rabbitmq

    builder.Services.AddMassTransitHostedService();

    builder.Services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy",
        builder => builder
        .SetIsOriginAllowed((host) => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
        //cors set up
      
    });



    var app = builder.Build();
    //logs every requests
   // app.UseSerilogRequestLogging(c =>
    //{
     //   c.MessageTemplate = "HTTP {RequestMethod} {RequestPath} {UserId} responded {StatusCode} in {Elapsed:0.0000}ms";
   // });

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProductService v1"));
    }

    app.UseHttpsRedirection();

    app.UseCors("corsPolicy");

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}
return 0;