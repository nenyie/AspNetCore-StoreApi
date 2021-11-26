using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Domain.AggregateModel.StoreAggregate
{
    public class StoreInformation
    {
        public int Id { get; set; }
        public int StoreName { get; set; }
        public string StoreRating { get; set; }
       // public StoreType StoreType { get; set; } 
        public string BrandPhoto { get; set; }
        public string FaceBook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Website { get; set; }
        public string Google { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string FAX { get; set; }
        public int PhoneNumber { get; set; }
        public int PhoneNumber2 { get; set; }
        public Store Store { get; set; }
        public int FK_StoreInformation_Store { get; set; }
    }
}
