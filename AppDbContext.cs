using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEndReservations.Models;

namespace BackEndReservations
{

    public class AppDbContext:DbContext
    {

        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactType> ContactType { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

    }
}
