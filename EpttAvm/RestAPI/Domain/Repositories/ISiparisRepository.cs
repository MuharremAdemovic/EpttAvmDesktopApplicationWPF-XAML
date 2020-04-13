using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;

namespace RestAPI.Domain.Repositories
{
    interface ISiparisRepository
    {
        Task<QueryResult<Siparis>> ListAsync(SiparisQuery query);
        Task AddAsync(Siparis siparis);
        Task<Siparis> FindByIdAsync(int id);
        void Update(Siparis siparis);
        void Remove(Siparis siparis);
    }
}
