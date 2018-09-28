using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SportzerMedia.AppLayer.Orders;

namespace SportzerMedia.Api.Infrastructure.Converters
{
    public class OrdersJsonConverter : JsonCustomConverte<OrdersBase>
    {
        private readonly Dictionary<OrdersPartnerType, Type> _types = new Dictionary<OrdersPartnerType, Type>
        {
            {OrdersPartnerType.PartnerA, typeof(OrdersPartnerA)},
            {OrdersPartnerType.PartnerB, typeof(OrdersPartnerB)},
            {OrdersPartnerType.PartnerC, typeof(OrdersPartnerC)},
            {OrdersPartnerType.PartnerD, typeof(OrdersPartnerD)}
        };

        protected override OrdersBase Create(Type objectType, JObject jObject)
        {
            return (OrdersBase)jObject.ToObject(_types[Enum.Parse<OrdersPartnerType>(
            jObject.GetValue("partner", StringComparison.InvariantCultureIgnoreCase).Value<string>(), true)]);
        }
    }
}
