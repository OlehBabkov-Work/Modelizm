using Modelizm.DAL.Entities;
using Modelizm.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Modelizm.DAL.EF;

namespace Modelizm.DAL.Repositories
{
	public class SessionRepository : IRepository<Session>
	{
		private readonly ModelizmContext _context;

		public SessionRepository(ModelizmContext context)
		{
			_context = context;
		}

		public IEnumerable<Session> GetAll()
		{
			return _context.Sessions.Include(u => u.User);
		}

		public Session Get(int id)
		{
			return _context.Sessions.Find(id);
		}

		public IEnumerable<Session> Find(Func<Session, bool> predicate)
		{
			return _context.Sessions.Include(u => u.User).Where(predicate).ToList();
		}

		public void Create(Session session)
		{
			_context.Sessions.Add(session);
		}

		public void Update(Session session)
		{
			_context.Entry(session).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			var session = Get(id);
			if (session != null)
				_context.Sessions.Remove(session);
		}
	}
}
