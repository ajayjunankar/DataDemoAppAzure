using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataDemoApp.Models;

namespace DataDemoApp.Data
{
    public class DataDemoAppContext : DbContext
    {
        public DataDemoAppContext (DbContextOptions<DataDemoAppContext> options)
            : base(options)
        {
        }

        public DbSet<DataDemoApp.Models.Employee> Employees { get; set; } = default!;
    }
}
