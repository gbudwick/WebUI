using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoveLink.Applications.Member.Models
{
    public class BaseEntity
    {
        [Key] public Guid Id { get; set; }

        [Required(ErrorMessage = "A created date is required")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "A modified date is required")]
        public DateTime ModifiedDate { get; set; }
    }
}
