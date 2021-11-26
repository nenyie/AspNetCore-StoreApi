using Product.Domain.AggregateModel.ProductAggregate;
using Product.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Infrastructure.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWork, IDisposable
    {
        private bool disposedValue;

        public ProductContext Context { get; }
        //public readonly IProductRepository Product;
        public IProductRepository Product { get; private set; }

        // IProductRepository ProductRepositoy to the constructor
        public UnitOfWorkRepository(ProductContext productContext)
        {
            Context = productContext;
            Product = new ProductRepository(productContext);
           // Product = ProductRepositoy;
        }

        public Task<int> Save(CancellationToken cancellationToken)
        {
            var result = Context.SaveChangesAsync(cancellationToken);
            return result;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWorkRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        //public IProductRepository ProductRepository
        //{
        //    get
        //    {
        //        if (this.Product == null)
        //        {
        //            return new ProductRepository(Context);
        //        }
        //        return Product;
        //    }
        //}


    }

    // controller, _unitOfWork.product.GetAllProducts(ProductEntity ent)
    //await _unitOfWork.Product.DeleteProduct(id);
    //await _unitOfWork.Save();
}
