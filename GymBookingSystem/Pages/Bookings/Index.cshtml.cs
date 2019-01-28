using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GymBookingSystem.Models;

namespace GymBookingSystem.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly GymBookingSystem.Models.BookingsContext _context;

        public IndexModel(GymBookingSystem.Models.BookingsContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; }

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking.ToListAsync();
        }
    }
}
