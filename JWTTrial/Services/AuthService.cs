using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTTrial.Models;

namespace JWTTrial.Services
{
	public class AuthService : IAuthService
	{
		public int GetUserType(string Username)
		{
			///Write your database queries
			///For now I am hardcoding this
			if (Username == "Admin")
				return Convert.ToInt32(UserType.Types.Administrator);
			else if(Username == "User")
				return Convert.ToInt32(UserType.Types.User);
			else
				return Convert.ToInt32(UserType.Types.Guest);
		}

		public User VerifyUser(string Username, string Password)
		{

		}
	}
}
