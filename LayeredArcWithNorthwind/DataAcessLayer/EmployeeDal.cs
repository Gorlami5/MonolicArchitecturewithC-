using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
   
    public class EmployeeDal : IEmployeeDal
    {
        public void Add(Employee entity)
        {
            using (ConnectionDb connectionDb = new ConnectionDb())
            {
                connectionDb.Add(entity);
                connectionDb.SaveChanges();
            }
        }

        public void Delete(Employee entity)
        {
            using (ConnectionDb connectionDb = new ConnectionDb())
            {
                connectionDb.Remove(connectionDb.Products.SingleOrDefault(e =>e.ProductID  == entity.Id));
                connectionDb.SaveChanges();
            }
        }

        public List<Employee> GetAll()
        {
            using (ConnectionDb connectionDb = new ConnectionDb())
            {
                return connectionDb.Employees.ToList();
            }
        }

        public Employee GetById(int id)
        {
            using (ConnectionDb connectionDb = new ConnectionDb())
            {
                return connectionDb.Employees.SingleOrDefault(e => e.Id == id);
            }
        }

        public void Update(Employee entity)
        {
            using (ConnectionDb connectionDb = new ConnectionDb())
            {
                var Updateto = connectionDb.Employees.SingleOrDefault(e => e.Id == entity.Id);
                Updateto.Id = entity.Id;
                Updateto.Name = entity.Name;
                Updateto.Surname = entity.Surname;
                connectionDb.SaveChanges();
               
            }
        }
    }
}
