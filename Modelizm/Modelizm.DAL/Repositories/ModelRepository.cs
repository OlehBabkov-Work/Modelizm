using Modelizm.DAL.EF;
using Modelizm.DAL.Entities;
using Modelizm.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Modelizm.DAL.Repositories
{
	public class ModelRepository : IRepository<Model>
	{
		private readonly ModelizmContext _context;

		public ModelRepository(ModelizmContext context)
		{
			_context = context;
		}

		public IEnumerable<Model> GetAll()
		{
			return _context.Models;
		}

		public Model Get(int id)
		{
			return _context.Models.Find(id);
		}

		public IEnumerable<Model> Find(Func<Model, bool> predicate)
		{
			return _context.Models.Where(predicate).ToList();
		}

		public void Create(Model item)
		{
			_context.Models.Add(item);
		}

		public void Update(Model item)
		{
			_context.Entry(item).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			var model = _context.Models.Find(id);
			if (model != null)
				_context.Remove(model);
		}
	}
}
