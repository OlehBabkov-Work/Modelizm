using System;
using System.Collections.Generic;
using System.Text;

namespace Modelizm.DAL.Entities
{
	public class Model
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }

		public int CompanyId { get; set; }
		public Company Company { get; set; }

		public ICollection<Order> Orders { get; set; }
	}
}
