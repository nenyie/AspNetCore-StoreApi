using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.AggregateModel.StoreAggregate
{
    public class Store
    {
        public Guid Id { get; set; }
        public int StoreNumber { get; set; }
        public int StoreRating { get; set; }
        public Store(Guid id)
        {
            Id = id;         
        }
    }
}
