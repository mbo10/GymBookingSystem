using GymBookingSystem.Models;
using System;
using System.Linq;

namespace GymBookingSystem.Models
{
    public static class DbInitializer
    {
        public static void Initialize(BookingsContext context)
        {
            //context.Database.EnsureCreated();

            
            if (context.Booking.Any())
            {
                return;   // DB has been seeded
            }

            var bookings = new Booking[]
            {
            new Booking{RoomID=1,ClassID=1,MemberID=1,ClassName="Yoga",Date="01/02/2019 09:00",Room="5A"},
            new Booking{RoomID=2,ClassID=2,MemberID=2,ClassName="TaeBo",Date="01/02/2019 11:00",Room="3A"},
            new Booking{RoomID=3,ClassID=3,MemberID=3,ClassName="Kickbox",Date="01/02/2019 13:00",Room="4"},
            new Booking{RoomID=4,ClassID=4,MemberID=4,ClassName="Spinning",Date="01/02/2019 16:00",Room="1"},
            new Booking{RoomID=5,ClassID=5,MemberID=5,ClassName="Pilates",Date="01/02/2019 17:00",Room="2"},
            };
            foreach (Booking s in bookings)
            {
                context.Booking.Add(s);
            }
            context.SaveChanges();

            var classes = new Class[]
            {
            new Class{ClassName="Yoga",RoomID=1,Date="01/02/2019 09:00",Instructor="Martin"},
            new Class{ClassName="TaeBo",RoomID=2,Date="01/02/2019 10:00",Instructor="Kavita"},
            new Class{ClassName="Kickbox",RoomID=3,Date="01/02/2019 12:00",Instructor="Remus"},
            new Class{ClassName="Spinning",RoomID=4,Date="01/02/2019 13:00",Instructor="Juwon"},
            new Class{ClassName="Pilates",RoomID=5,Date="01/02/2019 15:00",Instructor="Suraj"},
            };
            foreach (Class c in classes)
            {
                context.Class.Add(c);
            }
            context.SaveChanges();

            var members = new Member[]
            {
            new Member{Name="Luke",Username="lukeskywalker2",Password="123",Email="lukeTheLegend@skymail.ac.uk"},
            new Member{Name="Ravin",Username="manlikeRavG",Password="321123332211",Email="RoadmanRav@skymail.ac.uk"},
            new Member{Name="Brandon",Username="itsBrandonBish",Password="!422BranDon2233!BDon",Email="Bigbrad@skymail.ac.uk"},
            };
            foreach (Member e in members)
            {
                context.Member.Add(e);
            }
            context.SaveChanges();

            var rooms = new Room[]
            {
            new Room{RoomNumber="5A",Capacity=20,MemberID=1},
            new Room{RoomNumber="3A",Capacity=15,MemberID=2},
            new Room{RoomNumber="4",Capacity=10,MemberID=3},
            new Room{RoomNumber="1",Capacity=20,MemberID=4},
            new Room{RoomNumber="2",Capacity=20,MemberID=5},
            };
            foreach (Member e in members)
            {
                context.Member.Add(e);
            }
            context.SaveChanges();
        }
    }
}