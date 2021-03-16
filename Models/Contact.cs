using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndReservations.Models
{
    [Table("contact")]
    public class Contact
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string contactName { get; set; }

        [Required]
        public string phoneNumber  { get; set; }

        [Required]
        public DateTime birthdate { get; set; }

        public virtual ContactType contactType { get; set; }
    }
}
