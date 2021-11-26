using Product.Saga.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Saga.StateMachine
{
    public class ProductMessageFailure : IProductMessageFailureEvent
    {
        public ProductMessageFailure()
        {

        }
        public Guid ProductId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Productdiscount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductPrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
