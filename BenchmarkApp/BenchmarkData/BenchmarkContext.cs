using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BenchmarkData;

namespace BenchmarkData
{
    public partial class BenchmarkContext : DbContext
    {
        public static BenchmarkContext Instance { get; } = new BenchmarkContext();


        public DbSet<User> Users { get; set; }
        public DbSet<Score> Scores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Benchmark;");
            }
        }
    }
}
