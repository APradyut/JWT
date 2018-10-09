using JWTTrial.Models;

namespace JWTTrial.Services
{
	public interface IAuthService
	{
		User VerifyUser(string Username, string Password);
		int GetUserType(string Username);
	}
}