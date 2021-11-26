using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.ProductDiscountAggregate
{
    public class ProductDiscontInfo
    {
        public int Id { get; set; }
        public DateTime DiscountExpiryDate { get; set; }
        public DateTime DiscontStartDate { get; set; }
        public int Discount { get; set; }
        public int DiscountValidityPeriod { get; set; }
        public bool IsDiscountavaliable { get; set; }

    }
}
