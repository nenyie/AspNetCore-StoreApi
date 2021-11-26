using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.SeedWork
{
    public abstract class Enumeration : IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
