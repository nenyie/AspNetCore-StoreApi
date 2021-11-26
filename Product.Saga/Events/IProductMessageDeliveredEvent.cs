using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Saga.Events
{
    public interface IProductMessageDeliveredEvent
    {
        public Guid ProductId { get; }
        public string Productdiscount { get; }
        public string ProductPrice { get; }
    }
}
