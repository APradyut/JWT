using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTrial.Models
{
	public class Token
	{
		public Token(string token, DateTime expiresOn)
		{
			YourToken = token;
			ExpiresOn = expiresOn;
		}
		public string YourToken { get; protected set; }
		public DateTime ExpiresOn { get; protected set; }
	}
}
