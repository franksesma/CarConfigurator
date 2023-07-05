namespace CarBuilder.Models
{
	public class CarOrder
	{
        public int Id { get; set; }
        public string CarName { get; set; }
        public float CarPrice { get; set; }
        public string BodyType { get; set; }
		public string BodyColor { get; set; }
		public string WheelType { get; set; }
		public string WheelColor { get; set; }
	}
}
