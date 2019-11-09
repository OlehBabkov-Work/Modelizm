using System;

namespace Modelizm.DAL.Entities
{
	public class Order
	{
		public int Id { get; set; }
		public decimal Sum { get; set; }
		public string Address { get; set; }
		public DateTime OrderDate { get; set; }
		public string Description { get; set; }

		public int ModelId { get; set; }
		public Model Model { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }
	}
}
