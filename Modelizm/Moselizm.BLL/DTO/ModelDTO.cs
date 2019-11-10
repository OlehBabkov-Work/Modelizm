using Modelizm.DAL.Entities;
using System;

namespace Moselizm.BLL.DTO
{
	public class ModelDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public DateTime CreatedDate { get; set; }
		public string ImageUrl { get; set; }
		public int CompanyId { get; set; }
		public int CategoryId { get; set; }
	}
}
