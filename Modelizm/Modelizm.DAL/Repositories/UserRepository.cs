using Modelizm.DAL.EF;
using Modelizm.DAL.Entities;
using Modelizm.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Modelizm.DAL.Repositories
{
	public class UserRepository : IRepository<User>
	{
		private readonly ModelizmContext _context;

		public UserRepository(ModelizmContext context)
		{
			_context = context;
		}

		public IEnumerable<User> GetAll()
		{
			return _context.Users;
		}

		public User Get(int id)
		{
			return _context.Users.Find(id);
		}

		public IEnumerable<User> Find(Func<User, bool> predicate)
		{
			return _context.Users.Where(predicate).ToList();
		}

		public void Create(User user)
		{
			_context.Users.Add(user);
		}

		public void Update(User user)
		{
			_context.Entry(user).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			var user = Get(id);
			if (user != null)
				_context.Users.Remove(user);
		}
	}
}
