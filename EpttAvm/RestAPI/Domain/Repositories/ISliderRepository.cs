using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;

namespace RestAPI.Domain.Repositories
{
    interface ISliderRepository
    {
        Task<QueryResult<Slider>> ListAsync();
        Task AddAsync(Slider slider);
        Task<Slider> FindByIdAsync(int id);
        void Update(Slider slider);
        void Remove(Slider slider);
    }
}
