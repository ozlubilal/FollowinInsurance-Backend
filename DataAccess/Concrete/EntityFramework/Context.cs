using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=InsuranceProject;Trusted_Connection=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<InsuranceType> InsuranceTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<HomeInsurance> HomeInsurances { get; set; }
        public DbSet<TrafficInsuranceType> TrafficInsuranceTypes { get; set; }
        public DbSet<TrafficInsurance> TrafficInsurances { get; set; }
        public DbSet<PersonalInsurance> PersonalInsurances { get; set; }
        public DbSet<InsuranceState> InsuranceStates { get; set; }

    }
}
