using Modelizm.DAL.Interfaces;
using Modelizm.DAL.Entities;
using System;
using Modelizm.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace Modelizm.DAL.Repositories
{
	public class EFUnitOfWork : IUnitOfWork
	{
		private ModelizmContext _context;

		private ModelRepository _modelRepository;
		private OrderRepository _orderRepository;
		private UserRepository _userRepository;
		private CategoryRepository _categoryRepository;
		private CompanyRepository _companyRepository;
		private SessionRepository _sessionRepository;

		public EFUnitOfWork(DbContextOptions<ModelizmContext> options)
		{
			_context = new ModelizmContext(options);
		}

		public IRepository<Model> Models
		{
			get
			{
				if (_modelRepository == null)
					_modelRepository = new ModelRepository(_context);

				return _modelRepository;
			}
		}

		public IRepository<Category> Categories
		{
			get
			{
				if (_categoryRepository == null)
					_categoryRepository = new CategoryRepository(_context);

				return _categoryRepository;
			}

		}

		public IRepository<Order> Orders
		{
			get
			{
				if (_orderRepository == null)
					_orderRepository = new OrderRepository(_context);

				return _orderRepository;
			}
		}
		public IRepository<Company> Companies
		{
			get
			{
				if (_companyRepository == null)
					_companyRepository = new CompanyRepository(_context);

				return _companyRepository;
			}
		}

		public IRepository<User> Users
		{
			get
			{
				if (_userRepository == null)
					_userRepository = new UserRepository(_context);

				return _userRepository;
			}
		}

		public IRepository<Session> Sessions
		{
			get
			{
				if (_sessionRepository == null)
					_sessionRepository = new SessionRepository(_context);

				return _sessionRepository;
			}
		}

		public void Save()
		{
			_context.SaveChanges();
		}

		private bool disposed = false;

		public virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}

				disposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
