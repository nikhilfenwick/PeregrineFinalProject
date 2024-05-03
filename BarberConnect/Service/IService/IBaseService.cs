using BarberConnect.Models;

namespace BarberConnect.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDTO> SendAsync(RequestDto requestDto);
        // Later this will be changed to work with authentication 
    }

}