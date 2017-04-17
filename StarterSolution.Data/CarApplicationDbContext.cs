using StarterSolution.Data.EntityConfigurations;
using StarterSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterSolution.Data
{
    public class CarApplicationDbContext : DbContext
    {
        public CarApplicationDbContext(string connectionString) : base(connectionString)
        {
        }

        public CarApplicationDbContext() : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Part> Parts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CarConfiguration());
        }
    }
}
