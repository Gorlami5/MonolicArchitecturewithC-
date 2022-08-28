using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        public List<T> GetAll();

        public T GetById(int id);

        public void Add(T entity);

        public void Update(T entity);

        public void Delete(T entity);
    }
}
