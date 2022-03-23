using MediatR;
using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.API.Application.Command.DeleteProduct
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public int DeeteProductId { get; set; }
        public DeleteProductCommand()
        {
            
        }
    }
}
