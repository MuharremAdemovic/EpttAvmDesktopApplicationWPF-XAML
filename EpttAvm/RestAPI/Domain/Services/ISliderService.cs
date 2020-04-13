using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;
using RestAPI.Domain.Services.Communication;

namespace RestAPI.Domain.Services
{
    public interface ISliderService
    {
        Task<IEnumerable<Slider>> ListAsync();
        Task<SliderResponse> SaveAsync(Slider slider);
        Task<SliderResponse> UpdateAsync(int id, Slider slider);
        Task<SliderResponse> DeleteAsync(int id);

    }
}
