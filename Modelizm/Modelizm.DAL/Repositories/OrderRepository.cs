using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Modelizm.DAL.EF;
using Modelizm.DAL.Entities;
using Modelizm.DAL.Interfaces;

namespace Modelizm.DAL.Repositories
{
	public class OrderRepository : IRepository<Order>
	{
		private readonly ModelizmContext _context;

		public OrderRepository(ModelizmContext context)
		{
			_context = context;
		}

		public IEnumerable<Order> GetAll()
		{
			return _context.Orders.Include(m => m.Model);
		}

		public Order Get(int id)
		{
			return _context.Orders.Find(id);
		}

		public IEnumerable<Order> Find(Func<Order, bool> predicate)
		{
			return _context.Orders.Where(predicate).ToList();
		}

		public void Create(Order order)
		{
			_context.Orders.Add(order);
		}

		public void Update(Order order)
		{
			_context.Entry(order).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			var order = Get(id);
			if (order != null)
				_context.Orders.Remove(order);
		}
	}
}
