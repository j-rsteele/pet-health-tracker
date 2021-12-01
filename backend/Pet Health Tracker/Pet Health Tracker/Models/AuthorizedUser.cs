using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Health_Tracker.Models
{
	public class AuthorizedUser
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
