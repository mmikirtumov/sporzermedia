namespace SportzerMedia.AppLayer.Orders
{
    public class OrdersBase
    {
        public OrdersPartnerType Partner { get; set; }

        public string OrderID { get;set;}

        public string TypeOfOrder { get; set; }

        public string SubmittedBy { get; set; }

        public string CompanyID { get; set; }

        public string CompanyName { get; set; }
    }
}
