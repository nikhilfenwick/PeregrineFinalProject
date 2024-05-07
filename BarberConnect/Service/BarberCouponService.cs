using BarberConnect.Models;
using BarberConnect.Service.IService;
using BarberConnect.Utility;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace BarberConnect.Service
{

    public class BarberCouponService : IBarberCouponService
    {

        private readonly IBaseService _baseService;
        public BarberCouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDTO?> CreateBarberCouponsAsync(BarberCouponDTO barbercouponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = barbercouponDto,
                Url = SD.BarberCouponAPIBase + "/api/barbercouponS/addingbarbercoupon"
            });
        }

        public async Task<ResponseDTO?> DeleteBarberCouponsAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.BarberCouponAPIBase + "/api/BarberCoupons/" + id
            });
        }

        public async Task<ResponseDTO?> GetAllBarberCouponsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.BarberCouponAPIBase + "/api/BarberCoupons/GetAllBarberCoupons"
            });
        }

        public async Task<ResponseDTO?> GetBarberCouponAsync(string barbercouponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.BarberCouponAPIBase + "/api/coupon/GetByCode/" + barbercouponCode
            });
        }

        public async Task<ResponseDTO?> GetBarberCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.BarberCouponAPIBase + "/api/Barbercoupons/" + id
            });
        }

        public async Task<ResponseDTO?> UpdateBarberCouponsAsync(BarberCouponDTO barbercouponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = barbercouponDto,
                Url = SD.BarberCouponAPIBase + "/api/barbercoupons/updatingbarbercoupon"
            });
        }

        public async Task<ResponseDTO?> GetAPICheckAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.BarberCouponAPIBase + "/api/barbercoupons/APICheck" 
            }
            );

        }
    }
}
