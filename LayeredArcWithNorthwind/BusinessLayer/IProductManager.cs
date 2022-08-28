using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IProductManager
    {
        public List<Product> GetAll();

        public Product GetById(int id);

        public void Add(Product entity);

        public void Update(Product entity);

        public void Delete(Product entity);
    }
}
