using System.Collections.Generic;
using Newtonsoft.Json;
using SportzerMedia.AppLayer.LineItems;

namespace SportzerMedia.AppLayer.Orders
{
    public class OrdersPartnerC : OrdersBase
    {
        public string ExposureID { get; set; }
        public string UDAC { get; set; }
        public string RelatedOrder { get; set; }
        public List<ILineItemsDetails> LineItems { get; set; }
    }
}
