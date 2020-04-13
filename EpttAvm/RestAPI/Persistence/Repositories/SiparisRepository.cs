using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;
using RestAPI.Domain.Repositories;
using RestAPI.Persistence.Contexts;

namespace RestAPI.Persistence.Repositories
{
	public class SiparisRepository : BaseRepository, ISiparisRepository
	{
		public SiparisRepository(AppDbContext context) : base(context) { }
		public Task AddAsync(Siparis siparis)
		{
			throw new System.NotImplementedException();
		}

		public Task<Siparis> FindByIdAsync(int id)
		{
			throw new System.NotImplementedException();
		}

		public Task<QueryResult<Siparis>> ListAsync(SiparisQuery query)
		{
			throw new System.NotImplementedException();
		}

		public void Remove(Siparis siparis)
		{
			throw new System.NotImplementedException();
		}

		public void Update(Siparis siparis)
		{
			throw new System.NotImplementedException();
		}
	}
}
