using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Saga.Events
{
    public interface IProductMessageFailureEvent
    {
        public Guid ProductId { get; set; }
        public string Productdiscount { get; set; }
        public string ProductPrice { get; set; }
    }
}
