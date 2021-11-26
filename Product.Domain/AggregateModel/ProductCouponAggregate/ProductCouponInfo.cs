using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.ProductCouponAggregate
{
    public class ProductCouponInfo
    {
        public int Id { get; set; }
        public int Coupon { get; set; }
        public DateTime CouponExpiryDate { get; set; }
        public DateTime CouponStartDate { get; set; }
        public int CouponValidityPeriod { get; set; }
        public bool IsCouponavaliable { get; set; }
    }
}
