
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
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
		public ActionResult<string> GetToken([FromBody][Required]string Username, [FromBody][Required]string Password)
		{
			if (ModelState.IsValid)
			{
				
				//Need the security key
				string SecurityKey = "This is a very long security key, which should not be stored or initialized here";
				//symmetric security key
				var SymmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey));
				//signing credentials
				var SigningCredentials = new SigningCredentials(SymmetricKey, SecurityAlgorithms.HmacSha256Signature);
				//create token
				var Claims = new List<Claim>();
				Claims.Add(new Claim(ClaimTypes.Role, "Administrator"));
				//return token
			}
			else return BadRequest(ModelState);
		}
    }
}