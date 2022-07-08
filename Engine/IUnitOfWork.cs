using Engine.Models;
using Engine.Repositories;

namespace Engine
{
    public interface IUnitOfWork
    {
        IGenericRepository<Customer> CustomerRepository { get; }
        IOrderRepository OrderRepository { get; }
        void Save();
        void Dispose();
    }
}