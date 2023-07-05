using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarBuilder.Data;
using CarBuilder.Models;

namespace CarBuilder.Pages.Checkout
{
	[BindProperties(SupportsGet = true)]
	public class CheckoutModel : PageModel
    {
		public string CarName { get; set; }
		public string BodyType { get; set; }
		public string BodyColor { get; set; }
		public string WheelType { get; set; }
		public string WheelColor { get; set; }
		public float CarPrice { get; set; }

        public void OnGet()
        {
			// If the car was personalized it might have no name
			if (string.IsNullOrWhiteSpace(CarName))
			{
				CarName = "Custom Car";
			}
		}
		public string GetBodyImagePath()
		{
			string imageName = BodyType + "_" + BodyColor;
			string imagePath = "/images/Body/" + imageName + ".png";
			return imagePath;
		}

		public string GetWheelImagePath()
		{
			string imageName = WheelType + "_" + WheelColor;
			string imagePath = "/images/Wheels/" + imageName + ".png";
			return imagePath;
		}
	}
}
