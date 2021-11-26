using Automatonymous;
using Product.Saga.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Saga.StateMachine
{
    public class ProductStateMachine : MassTransitStateMachine<ProductStateData>
    {
        public State Validation { get; set; }

        public Event<IProductMessageDeliveredEvent> StartOrderProcess { get; private set; }
        public ProductStateMachine()
        {
            InstanceState(s => s.CurrentState);

            Event(() => StartOrderProcess, x => x.CorrelateById(m => m.Message.ProductId));

            Initially(
                When(StartOrderProcess)
                .Then(context =>
                {
                    context.Instance.ProductId = context.Data.ProductId;
                    context.Instance.ProductPrice = context.Data.ProductPrice;
                    context.Instance.Productdiscount = context.Data.Productdiscount;
                })
                .TransitionTo(Validation)
                .Publish(context => new ProductMessageDelivered(context.Instance))
                .Finalize()
                );
        }
    }
  
}
