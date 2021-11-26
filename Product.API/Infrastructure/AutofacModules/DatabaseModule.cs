using Autofac;
using Product.API.Application.Queries;
using Product.Domain.AggregateModel.ProductAggregate;
using Product.Domain.SeedWork;
using Product.Infrastructure;
using Product.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.API.Infrastructure.AutofacModules
{
    public class DatabaseModule : Module
    {
        //private string Dbconnectionstring { get; }
        public DatabaseModule()
        {
            // Dbconnectionstring = dbconnectionstring ?? throw new ArgumentNullException(nameof(dbconnectionstring));
        }

        protected override void Load(ContainerBuilder builder)
        {
            // builder.Register(c => new ProductQueries(dbconnectionstring))
            //    .As<IProductQueries>()
            //    .InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(typeof("Product.API").GetTypeInfo().Assembly)
            //  .AsImplementedInterfaces();
            builder.RegisterType<ProductRepository>()
               .As<IProductRepository>()
               .InstancePerLifetimeScope();

            builder.RegisterType<ProductQueries>()
                .As<IProductQueries>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWorkRepository>()
                .As<IUnitOfWork>()
                .InstancePerLifetimeScope();
        }
    }
}
