using Automatonymous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Saga.StateMachine
{
    public class ProductStateData : SagaStateMachineInstance
    {
        public Guid CorrelationId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CurrentState { get; set; }
        public DateTime ProductDeliveryTime { get; set; }
        public DateTime ProductCancelTime { get; set; }
        public Guid ProductId { get; set; }
        public string Productdiscount { get; set; }
        public string ProductPrice { get; set; }
    }
   
}
