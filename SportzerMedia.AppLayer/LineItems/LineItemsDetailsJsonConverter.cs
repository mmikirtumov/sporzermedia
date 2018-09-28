using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SportzerMedia.AppLayer.LineItems
{
    public class LineItemsDetailsJsonConverter : JsonConverter
    {
        private readonly string _websiteDetails = "WebsiteDetails";
        private readonly string _adWordCampaign = "AdWordCampaign";

        public override bool CanWrite { get; } = false;

        public override bool CanRead { get; } = true;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ILineItemsDetails);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var lineItemDetails = default(ILineItemsDetails);
            string returnObject = String.Empty;

            if (jsonObject.ContainsKey(_adWordCampaign))
            {
                lineItemDetails = new PaidSearchDetails();
                serializer.Populate(jsonObject.CreateReader(), lineItemDetails);

            }

            if(jsonObject.ContainsKey(_websiteDetails))
            {
                lineItemDetails = new WebSiteDetails();
                serializer.Populate(jsonObject.CreateReader(), lineItemDetails);
            }


            return lineItemDetails;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }
    }
}
