using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTrial.Models.RequestModels
{
	public class AuthControllerRequestModels
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
