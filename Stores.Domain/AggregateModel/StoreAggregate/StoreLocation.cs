﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Domain.AggregateModel.StoreAggregate
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public int ZipCode { get; set; }
        public int PostalCode { get; set; }
        public int PhoneNumber { get; set; }
        public int PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public StoreLogs StoreLogs { get; set; }
        public int FK_StoreLocation_StoreLogs { get; set; }
        public Store Store { get; set; }
        public int FK_StoreLocation_Store { get; set; }
    }
}
