using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndReservations.Models
{
    [Table("contacttype")]
    public class ContactType
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}