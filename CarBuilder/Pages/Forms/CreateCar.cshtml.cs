using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarBuilder.Models;

namespace CarBuilder.Pages.Forms
{
    public class CustomCarModel : PageModel
    {
        [BindProperty]
        public CarsModel Car { get; set; }
        public float CarPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            CarPrice = Car.CalculateFinalPrice();

			return RedirectToPage("/Checkout/Checkout", new { Car.BodyType, Car.BodyColor, Car.WheelType, Car.WheelColor, CarPrice });
        }
	}
}
