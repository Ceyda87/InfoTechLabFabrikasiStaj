using InfoTechLabProjeFabrikasi.Data.Identities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InfoTechLabProjeFabrikasi.Data
{
    public partial class InfoTechLabContext : IdentityDbContext<AppUser, AppRole, int>

    {
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Platform> Platforms { get; set; }

        public InfoTechLabContext(DbContextOptions<InfoTechLabContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Customer>().Ignore(x => x.Name);

            SeedCustomer(modelBuilder);
            SeedExpert(modelBuilder);
            SeedCategories(modelBuilder);
            SeedCities(modelBuilder);


        }




    }
    
    
        





    }

    

