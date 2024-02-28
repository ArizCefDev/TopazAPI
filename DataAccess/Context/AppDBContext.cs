using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<Score> Scores { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) 
            : base(options)
        {

        }
    }
}
