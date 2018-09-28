using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportzerMedia.AppLayer.Orders
{
    public interface IOrdersService
    {
        void SaveOrders(OrdersBase orders);
        List<OrdersBase> GetOrders();
    }
}
