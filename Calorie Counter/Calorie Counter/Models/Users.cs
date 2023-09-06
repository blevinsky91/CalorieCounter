using System;
namespace Calorie_Counter.Models
{
	public class Users
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public int Weight { get; set; }
		public int Height { get; set; }
		public enum Gender { get; set; }
	}
}

