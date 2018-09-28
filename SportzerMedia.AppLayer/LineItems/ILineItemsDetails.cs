using Newtonsoft.Json;

namespace SportzerMedia.AppLayer.LineItems
{
    [JsonConverter(typeof(LineItemsDetailsJsonConverter))]
    public interface ILineItemsDetails
    {
    }
}
