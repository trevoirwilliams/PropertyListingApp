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
    public class ContractTypeConfiguration : IEntityTypeConfiguration<ContractType>
    {
        public void Configure(EntityTypeBuilder<ContractType> builder)
        {
            builder.HasData(
                new ContractType
                {
                    Id = 1,
                    Name = "Short Term"
                },
                new ContractType
                {
                    Id = 2,
                    Name = "Long Term"
                }
            );
        }
    }
}
