using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportzerMedia.AppLayer.Orders
{
    public class OrdersService : IOrdersService
    {
        private static readonly List<OrdersBase> _ordersList = new List<OrdersBase>();

        public void SaveOrders(OrdersBase orders)
        {
            _ordersList.Add(orders);
        }

        public List<OrdersBase> GetOrders()
        {
            return _ordersList;
        }
    }
}
