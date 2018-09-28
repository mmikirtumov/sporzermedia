using System.Collections.Generic;
using Newtonsoft.Json;
using SportzerMedia.AppLayer.LineItems;

namespace SportzerMedia.AppLayer.Orders
{
    public class OrdersPartnerB : OrdersBase
    {
        public List<ILineItemsDetails> LineItems { get; set; }
    }
}
