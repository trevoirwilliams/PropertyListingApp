using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyListingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyListingApp.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City
                {
                    Id = 1,
                    Name = "Kingston"
                },
                new City
                {
                    Id = 2,
                    Name = "Mandeville"
                },
                new City
                {
                    Id = 3,
                    Name = "Montego Bay"
                },
                new City
                {
                    Id = 4,
                    Name = "Port Antonio"
                }
            );
        }
    }
}
