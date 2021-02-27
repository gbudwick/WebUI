using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoveLink.Applications.Member.Models
{
    [Table("Addresses")]
    public class Address : BaseEntity
    {
        public int MemberId { get; set; }

        [MaxLength(100)]
        public string Address1 { get; set; }

        [MaxLength(100)]
        public string Address2 { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(2)]
        public string State { get; set; }

        [MaxLength(9)]
        public string ZipCode { get; set; }

        public int? AddressType { get; set; }

        public bool? IsMailingAddress { get; set; }

        public AddressType AddressTypeDetail { get; set; }
    }
}
