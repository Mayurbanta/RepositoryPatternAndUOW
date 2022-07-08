using Engine.Models;
using Engine.Repositories;
using System;

namespace Engine
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly NorthwindContext _context = new();

        private IGenericRepository<Customer> _customerRepository;

        private IOrderRepository _orderRepository;

        public IGenericRepository<Customer> CustomerRepository
        {
            get
            {
                _customerRepository ??= new GenericRepository<Customer>(_context);
                return _customerRepository;
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                _orderRepository ??= new OrderRepository(_context);
                return _orderRepository;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }



        #region IDisposable


        private bool _disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
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

        #endregion
    }
}
