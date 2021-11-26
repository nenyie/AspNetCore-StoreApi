using MediatR;
using Product.Domain.AggregateModel.ProductAggregate;
using Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging;
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

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<ProductEntity> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var prodRating = new ProductRating(request.Five, request.Four, request.One, request.Two, request.Three);

            var productDesc = new ProductDescription(request.ProductName, request.StoreName, request.AmountBought);

            var leadE = new LeadTime_EsTime(request.LessThanTenDays, request.ZeroToTenDays, request.TenToTwentyDays,
                                                  request.FiftyToHundredDays, request.GreaterThan1000Days,
                                                   request.TwentyToFiftyDays);

            var leadQ = new LeadTime_Quantity(request.LessThanTen, request.ZeroToTen, request.TenToTwenty,
                                                     request.TwentyToFifty, request.FiftyToHundred, request.GreaterThan1000);


            var leadTime = new LeadTime(request.PackageDetails, request.Weight, request.Port, leadE, leadQ);

            var productAmt = new ProductAmount(request.ProductDiscount, request.GetCoupon, request.CouponExpiryDate, request.ProductPrice,
                                                request.MinimunPrice, request.MaximumPrice,
                                                    request.ProductOnSale, request.FreeShiping, request.IsNegotiable);

            //add productDiscount and prouctcoupon
            var productToUpdate = new ProductEntity(request.ProductDate, productDesc, request.Description, productAmt, prodRating, leadTime);

            var result = await productRepository.AddProduct(productToUpdate);
            return result;


        }
    }
}
