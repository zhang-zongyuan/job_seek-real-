using job_seek.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_seek.Server.Configurations.Entities
{
    public class DescriptionSeed : IEntityTypeConfiguration<DescriptionSeed>
    {
        public void Configure(EntityTypeBuilder<DescriptionSeed> builder)
        {
            builder.HasData(
                 new Description
                 {
                     Id = 1,
                     Name = "DescriptionA",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Description
                 {
                     Id = 2,
                     Name = "DescriptionB",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
            );
        }
    }
}
