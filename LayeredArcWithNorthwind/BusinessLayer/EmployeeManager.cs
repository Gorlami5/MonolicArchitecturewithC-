using DataAcessLayer;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeManager : IEmployeeManager
    {
        private IEmployeeDal _employeedal;

        public EmployeeManager(IEmployeeDal employeedal)
        {
            _employeedal = employeedal; 
        }

        public void Add(Employee entity)
        {
            if(entity.Name.Contains("Andrew") && entity.Surname.Contains("Fuller"))
            {
                throw new SameNameExcepiton("You cannot add same employee");
            }
            _employeedal.Add(entity);
        }

        public void Delete(Employee entity)
        {
            _employeedal?.Delete(entity);
        }

        public List<Employee> GetAll()
        {
            return _employeedal.GetAll();
        }

        public Employee GetById(int id)
        {      
            return _employeedal.GetById(id);
        }

        public void Update(Employee entity)
        {
            _employeedal.Update(entity);
        }
    }
}
