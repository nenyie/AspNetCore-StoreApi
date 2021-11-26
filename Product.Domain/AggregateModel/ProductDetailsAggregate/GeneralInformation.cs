using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.ProductDetailsAggregate
{
    public class GeneralInformation
    {
        //CONTACTINFO
   
        //Troubleshoot

        //productcontent
        public string ProductContent { get; set; }
        public int SupplyAmount { get; set; }
        public string SupplyDuration { get; set; }
    }
}
