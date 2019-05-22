using Supermarket.API.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Repositories
{
    interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
