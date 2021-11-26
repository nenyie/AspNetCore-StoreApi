using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.API.Application.Queries
{
    public class ProductViewModel
    {
        public class ProductDto
        {
            public ProductAmountDto ProductAmount { get; } = new ProductAmountDto();

            public int ProductEntityId;

            public int ProductDescriptionID;
            public string ProductName { get; set; }  = string.Empty;
            public string StoreName { get; set; } = string.Empty ;
            public int AmountBought { get; set; }
            public int Five { get; set; }
            public int Four { get; set; }
            public int Three { get; set; }
            public int Two { get; set; }
            public int One { get; set; }
            public int Product_Amount { get; set; }
            public int ProductDiscount { get; set; }
            public bool GetCoupon { get; set; }
            public ProductVerificationDto ProductVerification { get; set; }

        }

        public class ProductAmountDto
        {
            public int Id { get; set; }
            public int Product_Amount { get; set; }
            public int ProductDiscount { get; set; }
            public bool GetCoupon { get; set; }
        }


        public enum ProductVerificationDto
        {
            Verified,
            Notverified,
            Pending,
        }
    }
}







