using System;

namespace Product.API.Application.ProductViewModel
{
    public class CreateProductCommandDto
    {
        public bool GetCoupon { get; set; }
        public string Description { get; set; } = string.Empty;
        public int ProductDiscount { get; set; }
        public DateTime ProductDate { get; set; }
        public DateTime CouponExpiryDate { get; set; }
        public int ProductPrice { get; set; }
        public int? MinimunPrice { get; set; }
        public int? MaximumPrice { get; set; }
        public int ProductOnSale { get; set; }
        public int FreeShiping { get; set; }
        public bool IsNegotiable { get; set; }
        //select cartegory
        //public SelectCartegory SelectCartegory { get; set; }
        //lead time
        public string PackageDetails { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string Port { get; set; } = string.Empty;

        //public LeadTime_EsTime LeadTime_EsTime { get; set; }    
        public int LessThanTenDays { get; set; }
        public int ZeroToTenDays { get; set; }
        public int TenToTwentyDays { get; set; }
        public int TwentyToFiftyDays { get; set; }
        public int FiftyToHundredDays { get; set; }
        public int GreaterThan1000Days { get; set; }

        //public LeadTime_EsTime LeadTime_Quantity { get; set; }   
        public int LessThanTen { get; set; }
        public int ZeroToTen { get; set; }
        public int TenToTwenty { get; set; }
        public int TwentyToFifty { get; set; }
        public int FiftyToHundred { get; set; }
        public int GreaterThan1000 { get; set; }

        //public int Id { get; set; }
        public int Five { get; set; }
        public int Four { get; set; }
        public int Three { get; set; }
        public int Two { get; set; }
        public int One { get; set; }

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
    }
}
