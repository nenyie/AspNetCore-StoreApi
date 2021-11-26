using Product.Saga.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Saga.StateMachine
{
    public class ProductMessageDelivered : IProductMessageDeliveredEvent
    {
        private readonly ProductStateData productStateData;

        public ProductMessageDelivered(ProductStateData productStateData)
        {
            this.productStateData = productStateData;
        }
        public Guid ProductId => productStateData.ProductId;
        public string Productdiscount => productStateData.Productdiscount;
        public string ProductPrice => productStateData.ProductPrice;
    }
}
