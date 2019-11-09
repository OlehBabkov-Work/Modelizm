using System;

namespace Modelizm.DAL.Entities
{
	public class Session
	{
		public int Id { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }
	}
}
