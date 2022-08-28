using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public interface IAsyncEntityRepository<T> where T : class, IEntity, new()
    {
        Task<List<T>> GetAllAsync();

        Task AddAsync(T entity);

        
    }
}
