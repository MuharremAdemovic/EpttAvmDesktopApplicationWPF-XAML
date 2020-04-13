using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Domain.Models;
using RestAPI.Domain.Models.Queries;
using RestAPI.Domain.Services.Communication;

namespace RestAPI.Domain.Services
{
    public interface IUserServices
    {
        Task<IEnumerable<User>> ListAsync();
        Task<UserResponse> SaveAsync(User user);
        Task<UserResponse> UpdateAsync(int id, User user);
        Task<UserResponse> DeleteAsync(int id);
    }
}
