using Amazon.DynamoDBv2.DataModel;
using System;

namespace Insurance.Web.Model
{
    [DynamoDBTable("AditionalServices")]
    public class AditionalServices
    {
        [DynamoDBHashKey]
        public Guid Id { get; set; }
        public bool LegalAssistance { get; set; }
        public bool TechAssistance { get; set; }
        public bool CarAssistance { get; set; }
        public bool HomeAssistance { get; set; }
    }
}
