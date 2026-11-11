using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MamphoWebsite.Models;

namespace MamphoWebsite.Pages
{
    public class BookingsModel : PageModel
    {
        public List<Booking> AllBookings { get; set; }

        public void OnGet()
        {
            AllBookings = BookingStore.AllBookings;
        }

        public IActionResult OnPostDelete(int id)
        {
            var booking = BookingStore.AllBookings.FirstOrDefault(x => x.Id == id);
            if (booking != null)
            {
                BookingStore.AllBookings.Remove(booking);
            }
            return RedirectToPage("/Bookings");
        }
    }
}

