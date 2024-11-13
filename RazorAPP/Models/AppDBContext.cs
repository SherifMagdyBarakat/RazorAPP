using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;


namespace RazorAPP.Models
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }


    }
}
