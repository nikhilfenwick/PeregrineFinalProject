using BarberServicesAuthAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BarberServicesAuthAPI.Data
{

	public class AppDBContext : IdentityDbContext<ApplicationUser>
	{


		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
		{
			//empty for now.
		}

		public DbSet<ApplicationUser> ApplicationUsers { get; set; }

		//seeding database
		//also neccessary for later DB operations and changing stuff
		//part of basic config
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

		}

	}
}
