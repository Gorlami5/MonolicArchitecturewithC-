using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IEmployeeManager
    {
        public List<Employee> GetAll();

        public Employee GetById(int id);

        public void Add(Employee entity);

        public void Update(Employee entity);

        public void Delete(Employee entity);
    }
}
