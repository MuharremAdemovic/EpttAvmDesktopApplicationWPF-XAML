using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;
using RestAPI.Domain.Services.Communication;

namespace RestAPI.Domain.Services
{
    public interface ISiparisService
    {
        Task<QueryResult<Siparis>> ListAsync(SiparisQuery query);
        Task<SiparisResponse> SaveAsync(Siparis siparis);
        Task<SiparisResponse> UpdateAsync(int id, Siparis siparis);
        Task<SiparisResponse> DeleteAsync(int id);
    }
}
