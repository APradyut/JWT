
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JWTTrial.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JWTTrial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
		private Services.AuthService _auth = new Services.AuthService();
		[HttpPost("GetToken")]
		public ActionResult<Token> GetToken([FromBody]Models.RequestModels.AuthControllerRequestModels Input)
		{
			if (ModelState.IsValid)
			{
				
				//Get the security key from somewhere safe
				string SecurityKey = "This is a very long security key, which should not be stored or initialized here";

				//Create the Symmetric key from the security key
				var SymmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey));

				//Creating signing credentials
				var SigningCredentials = new SigningCredentials(SymmetricKey, SecurityAlgorithms.HmacSha256Signature);

				//Claims added according to the user
				var Claims = new List<Claim>();
				User Requester = _auth.VerifyUser(Input.Username, Input.Password);
				Claims.Add(new Claim(ClaimTypes.Role, UserType.Types.Guest.ToString()));

				//Create token
				var Token = new JwtSecurityToken(
					issuer: "CentralController",
					audience: "APP",
					expires: DateTime.Now.AddDays(1),
					signingCredentials: SigningCredentials,
					claims: Claims
					);

				Token TokenFinal = new Token(new JwtSecurityTokenHandler().WriteToken(Token), DateTime.Now.AddDays(1));

				//Return token
				return Ok(TokenFinal);
			}
			else return BadRequest(ModelState);
		}
    }
}