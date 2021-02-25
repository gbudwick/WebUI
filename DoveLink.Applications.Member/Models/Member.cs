using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoveLink.Applications.Member.Models
{
    [Table("Members")]
    public class Member : BaseEntity
    {
        public int ApplicationId { get; set; }

        [MaxLength(10)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string MiddleName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [MaxLength(75)]
        public string Email { get; set; }

        [MaxLength(13)]
        public string HomePhone { get; set; }

        public bool HomePhoneIsListed { get; set; }

        [MaxLength(13)]
        public string CellPhone { get; set; }

        [MaxLength(13)]
        public string WorkPhone { get; set; }

        public bool IsPrimaryAccountHolder { get; set; }

        [DefaultValue(0)]
        public int PrimaryMemberId { get; set; }

        [MaxLength(200)]
        public string Employer { get; set; }

        [MaxLength(50)]
        public string MothersMaidenName { get; set; }
    }
}
