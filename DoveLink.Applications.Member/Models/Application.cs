using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoveLink.Applications.Member.Models
{
    [Table("Applications")]
    public class Application : BaseEntity
    {
        [MaxLength(50)]
        public string ApplicationName { get; set; }

        [MaxLength(50)]
        public string ApplicationReference { get; set; }
    }
}
