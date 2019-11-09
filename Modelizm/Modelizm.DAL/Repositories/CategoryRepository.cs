using System;
using System.Collections.Generic;
using Modelizm.DAL.EF;
using Modelizm.DAL.Entities;
using Modelizm.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Modelizm.DAL.Repositories
{
	public class CategoryRepository : IRepository<Category>
	{
		private readonly ModelizmContext _context;

		public CategoryRepository(ModelizmContext context)
		{
			_context = context;
		}

		public IEnumerable<Category> GetAll()
		{
			return _context.Categories;
		}

		public Category Get(int id)
		{
			return _context.Categories.Find(id);
		}

		public IEnumerable<Category> Find(Func<Category, bool> predicate)
		{
			return _context.Categories.Where(predicate).ToList();
		}

		public void Create(Category category)
		{
			_context.Categories.Add(category);
		}

		public void Update(Category category)
		{
			_context.Entry(category).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			var category = Get(id);
			if (category != null)
				_context.Categories.Remove(category);
		}
	}
}
