using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging
{
    public class LeadTime
    {
        public int Id { get; set; }
        public string PackageDetails { get; set; }   //cartons,packets,boxes
        public string Weight { get; set; }
        public string Port { get; set; }
       
        public LeadTime_EsTime LeadTime_EsTime { get; set; }
        public int LeadTime_EsTimeFk { get; set; }

        public LeadTime_Quantity LeadTime_Quantity { get; set; }
        public int LeadTime_QuantityFk { get; set; }

        //relationships
        public ProductEntity ProductEntityLeadTime { get; set; }
        public int ProductEntityLeadTimeFK { get; set; }

        public LeadTime()
        {

        }
        public LeadTime(string packageDetails, string weight, string port, LeadTime_EsTime leadTime_EsTime,
                                LeadTime_Quantity leadTime_Quantity)
        {       
            PackageDetails = packageDetails;
            Weight = weight;
            Port = port;
            LeadTime_EsTime = leadTime_EsTime;
            LeadTime_Quantity = leadTime_Quantity;
        }
       

    }
}
