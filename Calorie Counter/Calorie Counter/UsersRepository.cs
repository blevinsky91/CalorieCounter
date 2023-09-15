using System;
using System.Data;

namespace Calorie_Counter
{
	public class UsersRepository : IUsers
	{
		private readonly IDbConnection _connection;
			
		public UsersRepository(IDbConnection connection)
		{
			_connection = connection;
		}
	}
}

