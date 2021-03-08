using Amazon.DynamoDBv2.DataModel;
using System;

namespace InsuranceWeb.Transversal
{
    public class Entity
    {
        [DynamoDBHashKey]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
