using BarberConnect.Models;

namespace BarberConnect.Service.IService
{
	public interface IAuthService
	{
		Task<ResponseDTO?> LoginAsync(LoginRequestDto loginRequestDto);
		Task<ResponseDTO?> RegisterAsync(RegistrationRequestDto registrationRequestDto);
		Task<ResponseDTO?> AssignRoleAsync(RegistrationRequestDto registrationRequestDto);
	}
}
