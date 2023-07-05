using System.Security.Cryptography.X509Certificates;

namespace CarBuilder.Models
{
	public class CarsModel
	{
		public string CarName { get; set; }
		public float BasePrice { get; set; } = 10000;
		public string BodyType { get; set; }
		public string BodyColor { get; set; }
		public string WheelType { get; set; }
		public string WheelColor { get; set;}
		public string ImagePath { get; set; }

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

        public float CalculateFinalPrice()
        {
			float CarPrice = BasePrice;
			if (BodyType == "compact")
			{
				CarPrice += 2500;
			}
			else if (BodyType == "hatchback")
			{
				CarPrice += 5000;
			}
			else if (BodyType == "coupe")
			{
				CarPrice += 10000;
			}

			if (WheelColor == "black")
			{
				CarPrice += 2500;
			}
			return CarPrice;
		}
    }
}
