using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    internal class CompanyDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server = DESKTOP-NA5GTK4\\MSSQLSERVER01; Database = CompanyG01; Trusted_Connection = True ; TrustServerCertificate = yes ");
        

        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Project> Projects { get; set; }
        //public DbSet<Product> Products { get; set; }
    }
}
