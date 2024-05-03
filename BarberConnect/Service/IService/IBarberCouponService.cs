using BarberConnect.Models;

namespace BarberConnect.Service.IService
{
    public interface IBarberCouponService
    {
        Task<ResponseDTO?> GetBarberCouponAsync(string barbercouponCode);
        Task<ResponseDTO?> GetAllBarberCouponsAsync();
        Task<ResponseDTO?> GetBarberCouponByIdAsync(int id);
        Task<ResponseDTO?> CreateBarberCouponsAsync(BarberCouponDTO barbercouponDto);
        Task<ResponseDTO?> UpdateBarberCouponsAsync(BarberCouponDTO barbercouponDto);
        Task<ResponseDTO?> DeleteBarberCouponsAsync(int id);
    }
}