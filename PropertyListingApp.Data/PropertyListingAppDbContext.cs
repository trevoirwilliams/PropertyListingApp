using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PropertyListingApp.Data.Configurations;
using PropertyListingApp.Data.Models;

namespace PropertyListingApp.Data
{
    public class PropertyListingAppDbContext : IdentityDbContext<ApiUser>
    {
        public PropertyListingAppDbContext(DbContextOptions<PropertyListingAppDbContext> contextOptions) : base(contextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new ContractTypeConfiguration());
            builder.ApplyConfiguration(new PropertyTypeConfiguration());
            builder.ApplyConfiguration(new CurrencyConfiguration());
        }


        public DbSet<City> Cities { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<PropertyFeature> PropertyFeatures { get; set; }
        public DbSet<PropertyListing> PropertyListings { get; set; }
    }
}
