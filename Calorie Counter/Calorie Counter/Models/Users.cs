using System;
namespace Calorie_Counter.Models
{
	public class Users
	{
		public int Id { get; set; }
		public char UserName { get; set; }
		public char Password { get; set; }
		public int Age { get; set; }
		public char Email { get; set; }
		public int Weight { get; set; }
		public int Height { get; set; }
		public enum Gender { get; set; }
	}
}

