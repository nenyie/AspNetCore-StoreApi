using MediatR;
using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Product.API.Application.Command.UpdteProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ProductEntity>
    {
        public Task<ProductEntity> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
