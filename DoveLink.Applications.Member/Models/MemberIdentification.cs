using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoveLink.Applications.Member.Models
{
    [Table("MemberIdentifications")]
    public class MemberIdentification : BaseEntity
    {
        public int MemberId { get; set; }

        public int IdentificationTypeId { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Number { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
