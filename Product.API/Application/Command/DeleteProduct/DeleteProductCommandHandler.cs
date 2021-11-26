using MediatR;
using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace Product.API.Application.Command.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepository _ProductRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            this._ProductRepository = productRepository;
        }
        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var result = await _ProductRepository.DeleteProduct(request.DeeteProductId);
            if (!result)
            {
                return false;
            }
            return result;
        }
    }
}
