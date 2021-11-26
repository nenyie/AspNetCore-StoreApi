using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Domain.AggregateModel.StoreAggregate
{
    public class Store
    {

        public Guid Id { get; set; }
        public int StoreNumber { get; set; }
        public int StoreRating { get; set; }
        public StoreInformation StoreInformation { get; set; }
        public int FK_Store_StoreInformation { get; set; }
        public StoreLogs StoreLogs { get; set; }
        public int FK_Store_StoreLogs_StoreLocation { get; set; }
        public StoreLocation StoreLocation { get; set; }
        public int FK_Store_StoreLocation { get; set; }

        public StoreType StoreType { get; set; }

        public Store(Guid id, StoreInformation storeInformation, StoreLogs storeLogs, StoreLocation storeLocation, StoreType storeType)
        {
            Id = id;
            StoreInformation = storeInformation;
            StoreLogs = storeLogs;
            StoreLocation = storeLocation;
            StoreType = storeType;
        }
    }
}
