using System;
using Modelizm.DAL.Entities;

namespace Modelizm.DAL.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<Model> Models { get; }

		IRepository<Category> Categories { get; }

		IRepository<Order> Orders { get; }

		IRepository<Company> Companies { get; }

		IRepository<User> Users { get; }

		IRepository<Session> Sessions { get; }

		void Save();
	}
}
