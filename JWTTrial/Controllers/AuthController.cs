using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JWTTrial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
		[HttpPost("Token")]
		public ActionResult<string> GetToken()
		{
			//Need the security key
			string SecurityKey = "This is a very long security key, which should not be stored or initialized here";
			//symmetric security key
			var SymmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey));
			//signing credentials
			var SigningCredentials = new SigningCredentials(SymmetricKey, SecurityAlgorithms.HmacSha256Signature);
			//create token
			var Token     
			//return token

		}
    }
}