using BarberServicesAuthAPI.Models;
using BarberServicesAuthAPI.Models.DTO;

namespace BarberServicesAuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
