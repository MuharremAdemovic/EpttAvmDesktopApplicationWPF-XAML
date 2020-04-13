using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;
using RestAPI.Domain.Services.Communication;

namespace RestAPI.Domain.Services
{
    public interface ISepetService
    {
        Task<QueryResult<Sepet>> ListAsync(SepetQuery query);
        Task<SepetResponse> SaveAsync(Sepet sepet);
        Task<SepetResponse> UpdateAsync(int id, Sepet sepet);
        Task<SepetResponse> DeleteAsync(int id);
    }
}
