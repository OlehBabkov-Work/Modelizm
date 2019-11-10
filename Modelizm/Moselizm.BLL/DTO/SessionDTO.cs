using System;

namespace Moselizm.BLL.DTO
{
	public class SessionDTO
	{
		public int Id { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int UserId { get; set; }
	}
}
