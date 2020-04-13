using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Domain.Repositories
{
    interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
