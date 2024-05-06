using BarberConnect.Service.IService;
using Microsoft.AspNetCore.Mvc;
using BarberConnect.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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

        public async Task<IActionResult> BarberCouponCreate()
		{
			return View();
		}

        [HttpPost]
        public async Task<IActionResult> BarberCouponCreate(BarberCouponDTO model)
        {
            if (ModelState.IsValid)
            {
                ResponseDTO? response = await _barbercouponService.CreateBarberCouponsAsync (model);
                if (response != null && response.IsSuccess) {
                    TempData["success"] = "Barber Coupon Created Successfully";
                    return RedirectToAction(nameof(BarberCouponIndex));
                }
            }

            return View(model); 
        }

        public async Task<IActionResult> APIStatus()
        {
        
            APICheckInfoDTO apiCheckInfoDTO = new APICheckInfoDTO();
            apiCheckInfoDTO.APICheckInformation = "Some Dummy Information"; 
            ResponseDTO? response = await _barbercouponService.GetAPICheckAsync();

            if (response != null && response.IsSuccess)
            {
                apiCheckInfoDTO = JsonConvert.DeserializeObject<APICheckInfoDTO>(Convert.ToString(response.Result)); 
            }
            else
            {
                TempData["error"] = response?.Message;

            }


            return View(apiCheckInfoDTO);
        
        }
        
    }

}