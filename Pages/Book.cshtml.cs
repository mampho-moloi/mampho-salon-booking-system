using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MamphoWebsite.Models;

namespace MamphoWebsite.Pages
{
    public class BookModel : PageModel
    {
        [BindProperty]
        public Booking NewBooking { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            NewBooking.Id = BookingStore.NextId++;
            BookingStore.AllBookings.Add(NewBooking);
            return RedirectToPage("/Bookings");
        }
    }
}