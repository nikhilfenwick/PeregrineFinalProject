using BarberConnect.Service.IService;
using Microsoft.AspNetCore.Mvc;
using BarberConnect.Models;
using Newtonsoft.Json;

namespace BarberConnect.Controllers
{

    public class BarberCouponController : Controller
    {
        private readonly IBarberCouponService _barbercouponService;
        // ToDo - Barber Coupon Service will come here. 
        public BarberCouponController (IBarberCouponService barberCouponService)
        {
            _barbercouponService = barberCouponService;
        }
        
        public IActionResult BarberCouponDummy()
        {
            // ToDo Data from coupon API will come here. 
            return View();
        }

        public async Task<IActionResult> BarberCouponIndex()
        {
            List <BarberCouponDTO>? list = new();

            ResponseDTO? response = await _barbercouponService.GetAllBarberCouponsAsync();

            if (response != null && response.IsSuccess)
            {
                TempData["success"] = "Coupon list has been loaded successfully";

                list = JsonConvert.DeserializeObject<List<BarberCouponDTO>>(Convert.ToString(response.Result));
            }
            
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(list); 
        }
        
    }





}