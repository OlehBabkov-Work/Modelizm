using System;
using System.Collections.Generic;
using System.Text;
using Modelizm.DAL.EF;
using Modelizm.DAL.Entities;
using Modelizm.DAL.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Modelizm.DAL.Repositories
{
	public class CompanyRepository : IRepository<Company>
	{
		private readonly ModelizmContext _context;

		public CompanyRepository(ModelizmContext context)
		{
			_context = context;
		}

		public IEnumerable<Company> GetAll()
		{
			return _context.Companies;
		}

		public Company Get(int id)
		{
			return _context.Companies.Find(id);
		}

		public IEnumerable<Company> Find(Func<Company, bool> predicate)
		{
			return _context.Companies.Where(predicate).ToList();
		}

		public void Create(Company company)
		{
			_context.Companies.Add(company);
		}

		public void Update(Company company)
		{
			_context.Entry(company).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			var company = Get(id);
			if (company != null)
				_context.Companies.Remove(company);
		}
	}
}
