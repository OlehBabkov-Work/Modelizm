﻿using System.Collections.Generic;

namespace Modelizm.DAL.Entities
{
	public class Company
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public string Description { get; set; }

		public ICollection<Model> Models { get; set; }
	}
}
