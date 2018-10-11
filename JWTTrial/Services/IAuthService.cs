using JWTTrial.Models;

namespace JWTTrial.Services
{
	public interface IAuthService
	{
		User VerifyUser(string Username, string Password);
		UserType.Types GetUserType(string Username);
	}
}