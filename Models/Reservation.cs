using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndReservations.Models
{
    [Table("reservation")]
    public class Reservation
    {

        [Required]
        public int id { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string numberRes { get; set; }

        [Required]
        public string dateBooking { get; set; }

        [Required]
        public int rating { get; set; }
    }
}
