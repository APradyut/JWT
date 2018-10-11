using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTTrial.Models;

namespace JWTTrial.Services
{
	public class AuthService : IAuthService
	{
		public UserType.Types GetUserType(string Username)
		{
			///Write your database queries
			///For now I am hardcoding this
			if (Username == "Admin")
				return UserType.Types.Administrator;
			else if(Username == "User")
				return UserType.Types.User;
			else
				return UserType.Types.Guest;
		}

		public User VerifyUser(string Username, string Password)
		{
			if (Username == "Admin" && Password == "Admin")
				return new User()
				{
					Password = "Admin",
					Username = "Admin",
					UserType = UserType.Types.Administrator
				};
			else if (Username == "User" && Password == "User")
				return new User()
				{
					Password = "User",
					Username = "User",
					UserType = UserType.Types.User
				};
			else return new User()
			{
				Password = "",
				Username = "",
				UserType = UserType.Types.Guest
			};
		}
	}
}
