using job_seek.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_seek.Server.Configurations.Entities
{
    public class CompanySeedConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                 new Company
                 {
                     Id = 1,
                     Name = "3 Series"
                 },
                 new Company
                 {
                     Id = 2,
                     Name = "X5"
                 },
                 new Company
                 {
                     Id = 3,
                     Name = "Prius"
                 },
                 new Company
                 {
                     Id = 4,
                     Name = "Rav4"
                 }
            );
        }
    }
}

