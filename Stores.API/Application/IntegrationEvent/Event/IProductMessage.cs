using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.API.Application.IntegrationEvent.Event
{
    public class IProductMessage
    {
        public string Productdiscount { get; set; }
        public string ProductPrice { get; set; }
    }
}
