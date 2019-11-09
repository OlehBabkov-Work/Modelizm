using System;
using System.Collections.Generic;
using System.Text;

namespace Modelizm.DAL.Entities
{
	public class User
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public bool IsAdmin { get; set; }

		public ICollection<Order> Orders { get; set; }
		public ICollection<Session> Sessions { get; set; }
	}
}
