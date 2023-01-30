using job_seek.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_seek.Server.Configurations.Entities
{
    public class JobSeedConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData(
                 new Job
                 {
                     Id = 1,
                     Year = 1,
                     Location = "3 Series",
                     MakeId= 1

                 },
                 new Job
                 {
                     Id = 2,
                     Year = 2,
                     Location = "X5",
                     MakeId = 2

                 },
                 new Job
                 {
                     Id = 3,
                     Year = 3,
                     Location = "Prius",
                     MakeId = 3

                 },
                 new Job
                 {
                     Id = 4,
                     Year = 4,
                     Location = "Rav4",
                     MakeId = 4

                 }
            );
        }
    }
}
