using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBookingSystem.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public int MemberID { get; set; }
    }
}