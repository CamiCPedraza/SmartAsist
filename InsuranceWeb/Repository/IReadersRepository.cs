using InsuranceWeb.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsuranceWeb.Repository
{
    public interface IReadersRepository
    {
        Task<AditionalServices> Single(Guid readerId);
        Task<AditionalServices> All(string paginationToken = "");
        //Task<IEnumerable<AditionalServices>> Find(SearchRequest searchReq);
        Task Add(AditionalServices entity);
        Task Remove(Guid readerId);
        //Task Update(Guid readerId, ReaderInputModel entity);
    }
}
