using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Models
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext()
        //{
        //}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) 
        {
            //ChangeTracker.Entries().Where(e => e.State == EntityState.Modified);
        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
