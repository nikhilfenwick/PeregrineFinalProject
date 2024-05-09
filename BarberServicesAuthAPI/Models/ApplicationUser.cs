using Microsoft.AspNetCore.Identity;

namespace BarberServicesAuthAPI.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string Name { get; set; }
	}
}
