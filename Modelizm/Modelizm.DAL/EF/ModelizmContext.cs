using Microsoft.EntityFrameworkCore;
using Modelizm.DAL.Entities;

namespace Modelizm.DAL.EF
{
	// TODO: Don't forget to create initializer in presentation project
	// TODO: Create DB Initializer class with mock entities
	public class ModelizmContext : DbContext
	{
		public ModelizmContext(DbContextOptions<ModelizmContext> options) : base(options)
		{ }

		public DbSet<Model> Models { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Session> Sessions { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
