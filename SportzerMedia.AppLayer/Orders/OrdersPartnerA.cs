using System.Collections.Generic;
using SportzerMedia.AppLayer.LineItems;
namespace SportzerMedia.AppLayer.Orders
{
    public class OrdersPartnerA : OrdersBase
    {
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMobile { get; set; }
        public string ContactEmail { get; set; }
        public List<WebSiteDetails> LineItems { get; set; }
    }
}
