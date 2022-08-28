using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer
{
    public class CustomerDal : ICustomerDal
    {
        public async Task AddAsync(Customer entity)
        {
            ConnectionDb connectionDb = new ConnectionDb();
            
                await connectionDb.AddAsync(entity);
                await connectionDb.SaveChangesAsync();
            
        }

        public Task<List<Customer>> GetAllAsync()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            
                return connectionDb.Customers.ToListAsync();
            
        }
    }
}
