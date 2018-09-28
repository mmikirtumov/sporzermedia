using System.Collections.Generic;
using SportzerMedia.AppLayer.LineItems;

namespace SportzerMedia.AppLayer.Orders
{
    public class OrdersPartnerD : OrdersBase
    {
        public List<PaidSearchDetails> LineItems { get; set; }
    }
}
