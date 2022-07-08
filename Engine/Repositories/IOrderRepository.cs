using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Engine.Models;

namespace Engine.Repositories
{
    public interface IOrderRepository: IGenericRepository<Order>
    {
        Order GetOrderFromShipVia(ShipVia shipVia);
    }
}