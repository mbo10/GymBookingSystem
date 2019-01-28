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
    public class DetailsModel : PageModel
    {
        private readonly GymBookingSystem.Models.BookingsContext _context;

        public DetailsModel(GymBookingSystem.Models.BookingsContext context)
        {
            _context = context;
        }

        public Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Booking.FirstOrDefaultAsync(m => m.BookingID == id);

            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
