using InsuranceWeb.Models;
using InsuranceWeb.Transversal;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsuranceWeb.Repository.Definitions
{
    public interface IRepository<T> where T : Entity
    {
        T FindById(Guid readerId);
        IEnumerable<T> GetAll(T model);
        //Task<IEnumerable<AditionalServices>> Find(SearchRequest searchReq);
        bool Add(T model);
        bool Remove(T model);
        //Task Update(Guid readerId, ReaderInputModel entity);
    }
}
