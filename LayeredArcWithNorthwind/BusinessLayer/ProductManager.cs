using DataAcessLayer;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductManager:IProductManager
    {
        private IProductDal _productdal;
        public ProductManager(IProductDal productDal1)
        {
            _productdal = productDal1;
        }

        public void Add(Product entity)
        {
            //Simple Exception
            if(entity.ProductName == "Geitost")
            {
                throw new SameProductException("You can't add same product");
            }
            _productdal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productdal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productdal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productdal.GetById(id);
        }

        public void Update(Product entity)
        {
            _productdal.Update(entity);
        }
    }
}
