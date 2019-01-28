using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBookingSystem.Models
{
    public class Class
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int RoomID { get; set; }
        public DateTime Date { get; set; }
        public string Instructor { get; set; }
    }
}