using job_seek.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_seek.Server.Configurations.Entities
{
    public class DescriptionSeedConfiguration : IEntityTypeConfiguration<DescriptionSeedConfiguration>
    {
        public void Configure(EntityTypeBuilder<DescriptionSeedConfiguration> builder)
        {
            builder.HasData(
                 new Description
                 {
                     Id = 1,
                     Name = "DescriptionA"

                 },
                 new Description
                 {
                     Id = 2,
                     Name = "DescriptionB"

                 }
            );
        }
    }
}
