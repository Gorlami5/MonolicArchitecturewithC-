using Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class ConnectionDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Database = Northwind;Trusted_Connection = true");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Customer> Customers { get; set; }

        //Custom Mapping

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Employee>().Property(p => p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Employee>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Employee>().Property(p => p.Surname).HasColumnName("LastName");
           
        }
        


    }
}
