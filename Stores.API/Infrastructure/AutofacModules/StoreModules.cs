using Autofac;
using Stores.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.API.Infrastructure.AutofacModules
{
    public class StoreModules : Module
    {
        public StoreModules()
        {

        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>();
        }
    }
}
