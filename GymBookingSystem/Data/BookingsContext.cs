using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GymBookingSystem.Models
{
    public class BookingsContext : DbContext
    {
        public BookingsContext (DbContextOptions<BookingsContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
