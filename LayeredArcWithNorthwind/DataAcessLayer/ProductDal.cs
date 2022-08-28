using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (ConnectionDb connectionDb = new ConnectionDb())
            {
                connectionDb.Add(entity);
                connectionDb.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (ConnectionDb connectionDb = new ConnectionDb())
            {
                connectionDb.Remove(connectionDb.Products.SingleOrDefault(p=> p.ProductID == entity.ProductID));
                connectionDb.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using(ConnectionDb connectionDb = new ConnectionDb()) 
            {
             return connectionDb.Products.ToList();
            }       
        }

        public Product GetById(int id)
        {
            using (ConnectionDb connectionDb = new ConnectionDb())
            {
                return connectionDb.Products.SingleOrDefault(p => p.ProductID == id);
            }
        }

        public void Update(Product entity)
        {
            using (ConnectionDb connectionDb = new ConnectionDb())
            {
               var Updateto = connectionDb.Products.SingleOrDefault(p => p.ProductID == entity.ProductID);
              
                Updateto.ProductName = entity.ProductName;
                Updateto.UnitPrice = entity.UnitPrice;
                Updateto.QuantityPerUnit = entity.QuantityPerUnit;
                Updateto.UnitsInStock = entity.UnitsInStock;
                connectionDb.SaveChanges();

            }
        }
    }
}
