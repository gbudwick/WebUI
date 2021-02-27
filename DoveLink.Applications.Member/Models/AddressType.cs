using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoveLink.Applications.Member.Models
{
    [Table("AddressTypes")]
    public class AddressType : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }

        public bool? Hidden { get; set; }
    }
}
