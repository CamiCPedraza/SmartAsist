using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using InsuranceWeb.Models;
using InsuranceWeb.Repository.Definitions;
using InsuranceWeb.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceWeb.Repository.Implementations
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly AmazonDynamoDBClient _client;
        private readonly DynamoDBContext _context;

        public Repository()
        {
            AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
            // This client will access the US East 1 region.
            clientConfig.RegionEndpoint = RegionEndpoint.USEast2;
            _client = new AmazonDynamoDBClient(clientConfig);
            _context = new DynamoDBContext(_client);
        }

        public bool Add(T model)
        {
            var result = _context.SaveAsync(model);
            return result.IsCompletedSuccessfully;
        }

        public IEnumerable<T> GetAll(T model)
        {
            return _context.QueryAsync<T>($"Amazon DynamoDB#DynamoDB{model} 1").GetRemainingAsync().Result;
        }

        public Task<IEnumerable<AditionalServices>> Find(AditionalServices searchReq)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T model)
        {
            return _context.DeleteAsync(model).IsCompletedSuccessfully;
        }

        public T FindById(Guid readerId)
        {
            return _context.LoadAsync<T>(readerId).Result;
        }

        public Task Update(Guid readerId, AditionalServices entity)
        {
            throw new NotImplementedException();
        }
    }
}
