using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyListingApp.Data.Models;

namespace PropertyListingApp.Data.Configurations
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.HasData(
                new Currency
                {
                    Id = 1,
                    Name = "Jamaican Dollar",
                    ShortName = "JMD"
                },
                new Currency
                {
                    Id = 2,
                    Name = "US Dollar",
                    ShortName = "USD"
                }
            );
        }
    }
}
