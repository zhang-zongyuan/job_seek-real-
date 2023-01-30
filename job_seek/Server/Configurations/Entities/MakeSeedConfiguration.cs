using job_seek.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_seek.Server.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                 new Make
                 {
                     Id = 1,
                     Name = "BMW"

                 },
                 new Make
                 {
                     Id = 2,
                     Name = "Toyota"

                 }
            );
        }
    }
}
