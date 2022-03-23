using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.ProductAggregate
{
    public class ProductAmount
    {
        public int Id { get; set; }
        public int ProductDiscount { get; set; }
        public bool GetCoupon { get; set; }
        public ProductEntity ProductEntity { get; set; }
        public int ProductEntityId { get; set; }
        public DateTime CouponExpiryDate { get; set; }    
        public int ProductPrice { get; set; }
        public int ProductOnSale { get; set; }
        public int FreeShiping { get; set; } 
        public bool IsNegotiable { get; set; }
        public ProductAmount( int productDiscount, bool getCoupon, DateTime couponExpiryDate, int productPrice,
           int productOnSale, int freeShiping, bool isNegotiable)
        {          
            ProductDiscount = productDiscount;
            GetCoupon = getCoupon;         
            CouponExpiryDate = couponExpiryDate;
            ProductPrice = productPrice;
            ProductOnSale = productOnSale;
            FreeShiping = freeShiping;
            IsNegotiable = isNegotiable;
        }         
    }

}
