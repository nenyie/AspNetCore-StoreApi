using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.ProductAggregate
{
    public class ProductDescription
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string StoreName { get; set; }
        public int AmountBought { get; set; }
       // public List<ProductEntity> ItemsBought { get; set; }     
        public ProductEntity ProductEntityAD { get; set; }
        public int EntityId { get; set; }

        public ProductDescription(        
            string productName,
            string storeName, 
            int amountBought)      
        {         
            ProductName = productName;
            StoreName = storeName;
            AmountBought = amountBought;       
        }
    }
}
