using CleanUp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanUp.DB
{
    public class CleanUpContext : DbContext
    {
        public CleanUpContext(DbContextOptions<CleanUpContext> options)
            : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
