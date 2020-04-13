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
	internal class UserService : IUserServices
	{
		private readonly IUsersRepository _usersRepository;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMemoryCache _cache;

		public UserService(IUsersRepository usersRepository,IUnitOfWork unitOfWork,IMemoryCache cache)
		{
			_usersRepository = usersRepository;
			_unitOfWork = unitOfWork;
			_cache = cache;
		}
		public Task<UserResponse> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<User>> ListAsync()
		{
			throw new NotImplementedException();
		}

		public Task<UserResponse> SaveAsync(User user)
		{
			throw new NotImplementedException();
		}

		public Task<UserResponse> UpdateAsync(int id, User user)
		{
			throw new NotImplementedException();
		}
	}
}
