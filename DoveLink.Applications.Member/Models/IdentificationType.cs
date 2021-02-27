using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoveLink.Applications.Member.Models
{
    public class IdentificationType : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }

        public bool? Hidden { get; set; }
    }
}
