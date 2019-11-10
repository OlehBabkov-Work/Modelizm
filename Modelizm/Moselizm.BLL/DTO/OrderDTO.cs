using System;

namespace Moselizm.BLL.DTO
{
	public class OrderDTO
	{
		public int Id { get; set; }
		public decimal Sum { get; set; }
		public string Address { get; set; }
		public DateTime OrderDate { get; set; }
		public string Description { get; set; }
		public int ModelId { get; set; }
		public int UserId { get; set; }
	}
}
