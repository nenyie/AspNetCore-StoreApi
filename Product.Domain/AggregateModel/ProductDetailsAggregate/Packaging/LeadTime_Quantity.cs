using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging
{
    public class LeadTime_Quantity
    {
        public int Id { get; set; }
        public int LessThanTen { get; set; }
        public int ZeroToTen { get; set; }
        public int TenToTwenty { get; set; }
        public int TwentyToFifty { get; set; }
        public int FiftyToHundred { get; set; }
        public int GreaterThan1000 { get; set; }

        public LeadTime LeadTimePK2 { get; set; }
        public int LeadTimeFk2 { get; set; }

        public LeadTime_Quantity(int lessThanTen, int zeroToTen, int tenToTwenty, 
            int twentyToFifty, int fiftyToHundred, int greaterThan1000)
        {      
            LessThanTen = lessThanTen;
            ZeroToTen = zeroToTen;
            TenToTwenty = tenToTwenty;
            TwentyToFifty = twentyToFifty;
            FiftyToHundred = fiftyToHundred;
            GreaterThan1000 = greaterThan1000;
            
        }

    }
}
