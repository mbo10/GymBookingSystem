﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GymBookingSystem.Models;

namespace GymBookingSystem.Pages.Bookings
{
    public class DeleteModel : PageModel
    {
        private readonly GymBookingSystem.Models.BookingsContext _context;

        public DeleteModel(GymBookingSystem.Models.BookingsContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Booking.FindAsync(id);

            if (Booking != null)
            {
                _context.Booking.Remove(Booking);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
