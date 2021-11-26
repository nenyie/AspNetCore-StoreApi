using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Domain.AggregateModel.TradeAggregate.TradeRevenueAggregate
{
    public class TradeRevenue
    {
        public int TotalRevenue { get; set; }
        public int WeeklyRevenue { get; set; }
        public DateTime RevenueForWeek { get; set; }
        public string TypeOfProductPerWeek { get; set; }
        public int QuantityOfProductSoldPerWeek { get; set; }
        public int QuantityOfProductRemainingPerWeek { get; set; }
        public int MonthlyRevenue { get; set; }
        public int YearlyRevenue { get; set; }
        public int DailyRevenue { get; set; }
        public int QuarterlyRevenue { get; set; }
        public int BiRevenue { get; set; }
    }
}
