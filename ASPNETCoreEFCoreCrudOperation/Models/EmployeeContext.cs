using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreEFCoreCrudOperation.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {

        }
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
