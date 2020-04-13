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
	internal class SepetService : ISepetService
	{
		private readonly IUsersRepository _usersRepository;
		private readonly ISepetRepository _sepetRepository;
		private readonly IProductRepository _productRepository;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMemoryCache _cache;

		public SepetService(IUsersRepository usersRepository, ISepetRepository sepetRepository, IProductRepository productRepository, IUnitOfWork unitOfWork, IMemoryCache cache)
		{
			_usersRepository = usersRepository;
			_productRepository = productRepository;
			_sepetRepository = sepetRepository;
			_unitOfWork = unitOfWork;
			_cache = cache;
		}

		public Task<SepetResponse> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<QueryResult<Sepet>> ListAsync(SepetQuery query)
		{
			throw new NotImplementedException();
		}

		public Task<SepetResponse> SaveAsync(Sepet sepet)
		{
			throw new NotImplementedException();
		}

		public Task<SepetResponse> UpdateAsync(int id, Sepet sepet)
		{
			throw new NotImplementedException();
		}
	}
}
