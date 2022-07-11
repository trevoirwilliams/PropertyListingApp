using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyListingApp.Data.Models;

namespace PropertyListingApp.Data.Configurations
{
    public class PropertyTypeConfiguration : IEntityTypeConfiguration<PropertyType>
    {
        public void Configure(EntityTypeBuilder<PropertyType> builder)
        {
            builder.HasData(
                new PropertyType
                {
                    Id = 1,
                    Name = "Apartment"
                },
                new PropertyType
                {
                    Id = 2,
                    Name = "Villa"
                },
                new PropertyType
                {
                    Id = 3,
                    Name = "House"
                },
                new PropertyType
                {
                    Id = 4,
                    Name = "Studio"
                }
            );
        }
    }
}
