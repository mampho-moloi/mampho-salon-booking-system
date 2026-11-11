namespace MamphoWebsite.Models
{
    public class Booking
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Service { get; set; }
            public string Date { get; set; }
            public string Notes { get; set; }
        }

        // This is our fake database for now - it just keeps bookings in memory
        public static class BookingStore
        {
            public static List<Booking> AllBookings = new List<Booking>();
            public static int NextId = 1;
        }
      }


