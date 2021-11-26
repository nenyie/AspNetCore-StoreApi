using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging
{
    public class LeadTime_EsTime
    {

        public int LeadId { get; set; }
        public int LessThanTenDays { get; set; }
        public int ZeroToTenDays { get; set; } 
        public int TenToTwentyDays { get; set; } 
        public int TwentyToFiftyDays { get; set; } 
        public int FiftyToHundredDays { get; set; } 
        public int GreaterThan1000Days { get; set; } 

        public LeadTime LeadTimePK { get; set; }
        public int LdTimeFk { get; set; }


        public LeadTime_EsTime( int lessThanTenDays, int zeroToTenDays, int tenToTwentyDays, 
            int twentyToFiftyDays, int fiftyToHundredDays, int greaterThan1000Days)
        {       
            LessThanTenDays = lessThanTenDays;
            ZeroToTenDays = zeroToTenDays;
            TenToTwentyDays = tenToTwentyDays;
            TwentyToFiftyDays = twentyToFiftyDays;
            FiftyToHundredDays = fiftyToHundredDays;
            GreaterThan1000Days = greaterThan1000Days;
            
        }
    }

}

