using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.API.Application.IntegrationEvent.Event
{
    public class ProductMessageConsumer : IConsumer<IProductMessage>
    {
        public async Task Consume(ConsumeContext<IProductMessage> context)
        {
            var data = context.Message;
            if(data.Productdiscount == null)
            {

            }
        }
    }
}
