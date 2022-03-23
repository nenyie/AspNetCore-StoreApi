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
        private readonly IProductRepository _ProductRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            this._ProductRepository = productRepository;
        }
        public async Task<ProductEntity> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var updrequest = new ProductEntity();
            var result = await _ProductRepository.UpdateProduct(updrequest);
          
            return result;
        }
    }
}
