using Product.Domain.AggregateModel.ProductCartegoryAggregate;
using Product.Domain.AggregateModel.ProductCartegoryAggregate.WomensCartegory.GeneralCartegory;
using Product.Domain.AggregateModel.ProductCouponAggregate;
using Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging;
using Product.Domain.AggregateModel.ProductDiscountAggregate;
using Product.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.ProductAggregate
{
    public class ProductEntity : IAggregateRoot
    {
        public int Id { get; set; }
        public DateTime ProductDate { get; set; }
        public int ProductRefNumber { get; set; }
        public int StockId { get; set; }
        public int StoreId { get; set; }
        public int CartegoryId { get; set; }
        public string CartegoryName { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public int MaximumStock { get; set; }
        public bool ActivateReorderLevel { get; set; }
        public ProductDescription ProductDescription { get; set; }
        public int ProductDescriptionID { get; set; }
        public string Description { get; set; }
        public ProductAmount ProductAmount { get; set; }
        public int ProductAmountID { get; set; }

       // public ProductRating ProductRating { get; set; }
       // public int ProductRatingFK { get; set; }

        public string ProductContent { get; set; }
        public int SupplyAmount { get; set; }
        public string SupplyDuration { get; set; }

       // public LeadTime LeadTime { get; set; }
       // public int LeadTimeFK { get; set; }    

        public ProductCouponInfo ProductCouponInfo { get; set; }
        public int Coupon { get; set; }

        public ProductDiscontInfo ProductDiscountInfo { get; set; }
        public int Discount { get; set; }

        public ProductVerification ProductVerification { get; set; }   

        public ProductEntity()
        {

        }

        public ProductEntity(DateTime productDate, ProductDescription productDescription, 
            string description, ProductAmount productAmount)
        {
            ProductDate = productDate;
            ProductDescription = productDescription;      
            Description = description;
            ProductAmount = productAmount;
            //
        }

    }
}

