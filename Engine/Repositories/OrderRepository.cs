using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Engine.Repositories
{
    public enum ShipVia
    {
        SpeedyExpress = 1,
        UnitedPackage = 2,
        FederalShipping = 3
    }


    public class OrderRepository: GenericRepository<Order>, IOrderRepository
    {
        private readonly NorthwindContext _context;

        public OrderRepository(NorthwindContext context): base(context)
        {
            _context = context;
        }


        public Order GetOrderShippingViaDetail(ShipVia shipVia)
        {
            return _context.Orders.FirstOrDefault(x => x.ShipVia == (int?)shipVia);
        }


    }
}
