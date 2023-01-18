using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job_seek.Shared.Domain
{
    public class Description : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}
