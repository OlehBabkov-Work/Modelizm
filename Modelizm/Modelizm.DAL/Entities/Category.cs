using System.Collections.Generic;

namespace Modelizm.DAL.Entities
{
	public class Category
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }

		public ICollection<Model> Models { get; set; }
	}
}
