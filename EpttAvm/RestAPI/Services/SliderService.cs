using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;
using RestAPI.Domain.Repositories;
using RestAPI.Domain.Services;
using RestAPI.Domain.Services.Communication;
using RestAPI.Infrastructure;

namespace RestAPI.Services
{
	internal class SliderService : ISliderService
	{
		private readonly ISliderRepository _sliderRepository;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMemoryCache _cache;

		public SliderService(ISliderRepository sliderRepository, IUnitOfWork unitOfWork, IMemoryCache cache)
		{
			_sliderRepository = sliderRepository;

			_unitOfWork = unitOfWork;
			_cache = cache;
		}
		public Task<SliderResponse> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Slider>> ListAsync()
		{
			throw new NotImplementedException();
		}

		public Task<SliderResponse> SaveAsync(Slider slider)
		{
			throw new NotImplementedException();
		}

		public Task<SliderResponse> UpdateAsync(int id, Slider slider)
		{
			throw new NotImplementedException();
		}
	}
}
