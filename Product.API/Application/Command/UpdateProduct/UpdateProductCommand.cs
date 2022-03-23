using MediatR;
using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.API.Application.Command.UpdteProduct
{
    public class UpdateProductCommand : IRequest<ProductEntity>
    {
        // public int Id { get; set; }
        public bool GetCoupon { get; set; }
        public string Description { get; set; } = string.Empty;
        public int ProductDiscount { get; set; }
        public DateTime ProductDate { get; set; }
        public DateTime CouponExpiryDate { get; set; }
        public int ProductPrice { get; set; }    
        public int ProductOnSale { get; set; }
        public int FreeShiping { get; set; }
        public bool IsNegotiable { get; set; }      
        //7328206018
        // public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string StoreName { get; set; } = string.Empty;
        public int AmountBought { get; set; } 
        // public int Id { get; set; }
        public int Coupon { get; set; }
        //public DateTime CouponExpiryDate { get; set; }
        public DateTime CouponStartDate { get; set; }
        public int CouponValidityPeriod { get; set; }
        public bool IsCouponavaliable { get; set; }
        //  public int Id { get; set; }
        public DateTime DiscountExpiryDate { get; set; }
        public DateTime DiscontStartDate { get; set; }
        public int Discount { get; set; }
        public int DiscountValidityPeriod { get; set; }
        public bool IsDiscountavaliable { get; set; }
    };
}