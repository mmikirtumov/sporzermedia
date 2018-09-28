using System;
using System.Collections.Generic;

namespace SportzerMedia.AppLayer.LineItems
{
    public class LineItemsBase
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProductType { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }
    }
}
