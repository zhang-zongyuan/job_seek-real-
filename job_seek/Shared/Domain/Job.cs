using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace job_seek.Shared.Domain
{
    public class Job : BaseDomainModel
    {
        [Required]
        public int Year { get; set; }

        [Required]
        [RegularExpression(@"^[A-Zaz]{3}\d{4}[A-Za-z]", ErrorMessage = "License Plate Number does not meet requirements")]
        public string Location { get; set; }

        [Required]
        public int? MakeId { get; set; }
        public virtual Make Make { get; set; }

        [Required]
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }

        [Required]
        public int? DescriptionId { get; set; }
        public virtual Description Description { get; set; }
        public virtual List<App> Apps { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Pay { get; set; }
    }
}
