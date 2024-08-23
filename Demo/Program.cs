using Demo.Contexts;
using Demo.Entities;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyDbContext dbContext = new CompanyDbContext();

            //dbContext.Employees.Add(new Employee());
            //dbContext.Employees.Where(E => E.Id == 10);
            dbContext.Set<Employee>().Where(E => E.Id == 10);

        }
    }
}
