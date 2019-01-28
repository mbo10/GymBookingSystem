using System;

namespace GymBookingSystem.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int RoomID { get; set; }
        public int ClassID { get; set; }
        public int MemberID { get; set; }
        public string ClassName { get; set; }
        public string Date { get; set; }
        public string Room { get; set; }
    }
}