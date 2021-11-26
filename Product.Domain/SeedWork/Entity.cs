using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.SeedWork
{
    public abstract class Entity
    {
        int? _requestedHashCode;
        int _id;
        public virtual int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        private List<INotification> _productDomainEvents;
        public IReadOnlyCollection<INotification> ProductDomainEvents => _productDomainEvents?.AsReadOnly();

        public void AddDomainEvents(INotification notification)
        {
            //_productDomainEvents = _productDomainEvents ?? new List<INotification>();
            _productDomainEvents ??= new List<INotification>();
            _productDomainEvents?.Add(notification);
        }

        public void RemoveDomainEvents(INotification notification)
        {
            _productDomainEvents.Remove(notification);
        }

        public void ClearDomainEvents()
        {
            _productDomainEvents?.Clear();
        }

        public bool IsTransient()
        {
            return this.Id == default;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            Entity item = (Entity)obj;

            if (item.IsTransient() || this.IsTransient())
                return false;
            else
                return item.Id == this.Id;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = this.Id.GetHashCode() ^ 31; // XOR for random distribution (http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx)

                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();

        }

        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
                return Equals(right, null);
            else
                return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
    }
}
