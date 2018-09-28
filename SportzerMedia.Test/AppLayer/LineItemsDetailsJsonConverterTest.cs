using System;
using Newtonsoft.Json;
using SportzerMedia.AppLayer.LineItems;
using Xunit;

namespace SportzerMedia.Test.AppLayer
{
    public class LineItemsDetailsJsonConverterTest
    {
        private string WebsiteDetailsJsonString => @"{ 
                                                        'ID': 1,
                                                        'ProductID': 'sample string 17',
                                                        'ProductType': 'sample string 18',
                                                        'Notes': 'sample string 53',
                                                        'Category': 'sample string 245',
                                                        'WebsiteDetails': {
                                                        'TemplateId': 'sample string 245',
                                                        'WebsiteBusinessName': 'sample string 245',
                                                        'WebsiteAddressLine1': 'sample string 246',
                                                        'WebsiteAddressLine2': 'sample string 247',
                                                        'WebsiteCity': 'sample string 248',
                                                        'WebsiteState': 'sample string 249',
                                                        'WebsitePostCode': 'sample string 250',
                                                        'WebsitePhone': 'sample string 257',
                                                        'WebsiteEmail': 'sample string 258',
                                                        'WebsiteMobile': 'sample string 259'
                                                        }
                                                        }";

        private string PaidSearchDetails => @"{
                                                    'ID': 1,
                                                    'ProductID': '6789',
                                                    'ProductType': 'Paid Search',
                                                    'Notes': 'sample string 53',
                                                    'Category': 'sample string 245',
                                                    'AdWordCampaign': {
                                                            'CampaignName': 'sample string 1',
                                                            'CampaignAddressLine1': 'sample string 2',
                                                            'CampaignPostCode': 'sample string 6',
                                                            'CampaignRadius': 'sample string 13',
                                                            'LeadPhoneNumber': 'sample string 14',
                                                            'SMSPhoneNumber': 'sample string 15',
                                                            'UniqueSellingPoint1': 'sample string 18',
                                                            'UniqueSellingPoint2': 'sample string 19',
                                                            'UniqueSellingPoint3': 'sample string 20',
                                                            'Offer': 'sample string 21',
                                                            'DestinationURL': 'sample string 23'
                                                            }
                                                        }";

        [Fact]
        public void Deserialize_WebSiteDetailJson_CrateWebSiteDetails()
        {
            var testJson = WebsiteDetailsJsonString;

            var result = JsonConvert.DeserializeObject<ILineItemsDetails>(testJson);
            var resultCheck = result as WebSiteDetails;

            Assert.NotNull(resultCheck);
        }

        [Fact]
        public void Deserialize_PaidSearchParam_CratePaidSearchDetails()
        {
            var testJson = PaidSearchDetails;

            var result = JsonConvert.DeserializeObject<ILineItemsDetails>(testJson);
            var resultCheck = result as PaidSearchDetails;

            Assert.NotNull(resultCheck);
        }
    }
}
