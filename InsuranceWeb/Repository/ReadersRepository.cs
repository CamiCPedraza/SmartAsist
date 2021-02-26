using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using InsuranceWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceWeb.Repository
{
    public class ReadersRepository : IReadersRepository
    {
        private readonly AmazonDynamoDBClient _client;
        private readonly DynamoDBContext _context;

        public ReadersRepository()
        {
            AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
            // This client will access the US East 1 region.
            clientConfig.RegionEndpoint = RegionEndpoint.USEast2;
            _client = new AmazonDynamoDBClient(clientConfig);
            _context = new DynamoDBContext(_client);
        }

        public async Task Add(AditionalServices entity)
        {
            var reader = new AditionalServices
            {
                Id = entity.Id,
                CarAssistance = entity.CarAssistance,
                HomeAssistance = entity.HomeAssistance,
                LegalAssistance = entity.LegalAssistance,
                TechAssistance = entity.TechAssistance
            };

            await _context.SaveAsync(reader);
        }

        public Task<AditionalServices> All(string paginationToken = "")
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AditionalServices>> Find(AditionalServices searchReq)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid readerId)
        {
            throw new NotImplementedException();
        }

        public Task<AditionalServices> Single(Guid readerId)
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid readerId, AditionalServices entity)
        {
            throw new NotImplementedException();
        }
    }
}
