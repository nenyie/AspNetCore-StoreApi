using MediatR;
using Product.Domain.AggregateModel.ProductAggregate;
using Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging;
using Product.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Product.API.Application.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductEntity>
    {
        private readonly IProductRepository productRepository;
        private readonly IUnitOfWork unitOfWork;

        public CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this.productRepository = productRepository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ProductEntity> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {

            var productDesc = new ProductDescription(request.ProductName, request.StoreName, request.AmountBought);


            var productAmt = new ProductAmount(request.ProductDiscount, request.GetCoupon, request.CouponExpiryDate, request.ProductPrice,                                           
                                                    request.ProductOnSale, request.FreeShiping, request.IsNegotiable);

            //add productDiscount and prouctcoupon
            var productToUpdate = new ProductEntity(request.ProductDate, productDesc, request.Description, productAmt);

            var result = await productRepository.AddProduct(productToUpdate);
            await unitOfWork.Save(cancellationToken);
            return result;
        }
    }
}