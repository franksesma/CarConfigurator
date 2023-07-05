using CarBuilder.Data;
using CarBuilder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CarBuilder.Pages.Checkout
{
	[BindProperties(SupportsGet = true)]
	public class ConfirmationModel : PageModel
	{
		public string CarName { get; set; }
		public string BodyType { get; set; }
		public string BodyColor { get; set; }
		public string WheelType { get; set; }
		public string WheelColor { get; set; }
		public float CarPrice { get; set; }

		// retrieve database
		private readonly ApplicationDbContext _context;
		public ConfirmationModel(ApplicationDbContext context)
		{
			_context = context;
		}
		public void OnGet()
        {
			// aAdding new car order to the database
			CarOrder carOrder = new CarOrder();
			carOrder.CarName = CarName;
			carOrder.BodyType = BodyType;
			carOrder.BodyColor = BodyColor;
			carOrder.WheelType = WheelType;
			carOrder.WheelColor = WheelColor;
			carOrder.CarPrice = CarPrice;

			_context.CarOrders.Add(carOrder);
			_context.SaveChanges();
		}
	}
}
