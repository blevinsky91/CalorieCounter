using System;
namespace Calorie_Counter.Models
{
	public class FoodProducts
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public double Proteins { get; set; }
		public double Fats { get; set; }
		public double Carbohydrates { get; set; }
	}
}

