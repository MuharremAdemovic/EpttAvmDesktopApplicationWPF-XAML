using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;

namespace RestAPI.Domain.Repositories
{
    interface ISepetRepository
    {
        Task<QueryResult<Sepet>> ListAsync(SepetQuery query);
        Task AddAsync(Sepet sepet);
        Task<Sepet> FindByIdAsync(int id);
        void Update(Sepet sepet);
        void Remove(Sepet sepet);
    }
}
