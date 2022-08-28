using DataAcessLayer;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerManager : ICustomerManager
    {
        private ICustomerDal _customerdal;

        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public async Task AddAsync(Customer entity)
        {
           await _customerdal.AddAsync(entity);
        }

        public Task<List<Customer>> GetAllAsync()
        {
           return _customerdal.GetAllAsync();
        }
    }
}
