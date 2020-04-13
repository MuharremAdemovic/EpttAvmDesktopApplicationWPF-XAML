using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;
using RestAPI.Domain.Repositories;
using RestAPI.Persistence.Contexts;

namespace RestAPI.Persistence.Repositories
{
	public class SliderRepository : BaseRepository, ISliderRepository
	{
		public SliderRepository(AppDbContext context) : base(context) { }

		public Task AddAsync(Slider slider)
		{
			throw new System.NotImplementedException();
		}

		public Task<Slider> FindByIdAsync(int id)
		{
			throw new System.NotImplementedException();
		}

		public Task<QueryResult<Slider>> ListAsync()
		{
			throw new System.NotImplementedException();
		}

		public void Remove(Slider slider)
		{
			throw new System.NotImplementedException();
		}

		public void Update(Slider slider)
		{
			throw new System.NotImplementedException();
		}
	}
}
