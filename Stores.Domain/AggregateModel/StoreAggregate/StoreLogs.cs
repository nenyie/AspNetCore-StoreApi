using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Domain.AggregateModel.StoreAggregate
{
    public class StoreLogs
    {
        public int Id { get; set; }
        public int AmountSold { get; set; }
        public int AmountBought { get; set; }
        public int ProductVisited { get; set; }
        public string SimilarStroes { get; set; }  //from differnt and same location and what product they compare with and how
        public int NumberOfClients { get; set; }
        public int NumberOfFemaleCustomer { get; set; }
        public int NumberOfMaleCustomer { get; set; }
        public int MainMarkets { get; set; }
        public int MainProducts { get; set; }
        public StoreLocation StoreLocation { get; set; }
        public int FK_StoreLogs_StoreLocation { get; set; }
        public Store Store { get; set; }
        public int FK_StoreLogs_Store { get; set; }
    }
}
