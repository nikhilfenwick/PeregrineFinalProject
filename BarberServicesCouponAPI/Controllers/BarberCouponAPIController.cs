using AutoMapper;
using BarberServicesCouponAPI.Data;
using BarberServicesCouponAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BarberServicesCouponAPI.Controllers
{
    [Route("api/BarberCoupons")]
    [ApiController]
    // Authorise will come here later

    public class BarberCouponApiController : ControllerBase
    {
        private readonly AppDBContext _db;
        // Mapper and DTO will come here
        
        public BarberCouponApiController(AppDBContext db)
        {
            _db = db;
            // DTO and Mapper will come here
        
        }

        [HttpGet]
        [Route("APICheck")]
        public string APICheck()
        {
            var checkString = "This messsage means the API is working";
            return checkString;
        }

        // Getting the entire list of Barber Coupons
        [HttpGet]
        [Route("GetAllBarberCoupons")]
        public List<BarberCoupon> GetListofBarberCoupons()
        {
            var listOfAllBarberCoupons = _db.barberCoupons.ToList();
            return listOfAllBarberCoupons;
        } 

    }

}