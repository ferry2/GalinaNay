namespace GalinaNay.Data
{
	using Microsoft.AspNet.Identity.EntityFramework;
	using Microsoft.Data.Entity;

	using GalinaNay.Models.Identity.Entity;

	public class GalinaNayDbContext : IdentityDbContext<User, Role, int>
	{
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(Configuration.GetConfigValue("Data:DefaultConnection:ConnectionString"));

			base.OnConfiguring(optionsBuilder);
		}
	}
}
