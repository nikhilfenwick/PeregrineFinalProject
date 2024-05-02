using AutoMapper;
using BarberServicesCouponAPI.Data;
using BarberServicesCouponAPI.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
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

        [HttpPost]
        // Authorise will come here
        [Route("AddingBarberCoupon")]
        public BarberCoupon Post([FromBody] BarberCoupon barberCoupon)
        {
            try 
            {
                // Dto will come here
                _db.barberCoupons.Add(barberCoupon);
                _db.SaveChanges();


            }

            catch(Exception ex)
            {
                barberCoupon.BarberCouponCode = "Something went wrong";
            }
            return barberCoupon;
        }

        [HttpPut]
        [Route("UpdatingBarberCoupon")]

        public BarberCoupon Put([FromBody] BarberCoupon barberCoupon)
        {
            try 
            {
                // Mapper will come here
                _db.barberCoupons.Update(barberCoupon);
                _db.SaveChanges();

                // Mapper will come here 

            }

            catch (Exception ex)
            {
                // _barberCoupon.IsSuccess = false; 
                // _barberCoupon.Message = ex.Message;
                // Dto will come here
                barberCoupon.BarberCouponCode = "Something went wrong";

            }

            return barberCoupon;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public BarberCoupon Delete(int id)
        {
            BarberCoupon barberCoupon = new BarberCoupon();
            try 
            {
                barberCoupon = _db.barberCoupons.First(u => u.BarberCouponId == id); 
                _db.barberCoupons.Remove(barberCoupon);
                _db.SaveChanges();  
            }

            catch (Exception ex)
            {
                // _barberCoupon.IsSuccess = false; 
                // _barberCoupon.Message = ex.Message;
                // Dto will come here
                barberCoupon.BarberCouponCode = "Something went wrong";

            }
            
            return barberCoupon;
        }

        [HttpGet]
        [Route("{id:int}")]

        public BarberCoupon GetByCode(int id)
        {
            BarberCoupon barberCoupon = new BarberCoupon(); 
            try
            {
            
            barberCoupon  = _db.barberCoupons.First(u => u.BarberCouponId == id);
            //_response.Result = obj;
            // _response.Result = _mapper.Map<CouponDTO>(obj); 
            // Mapper will come here

            }

            catch (Exception e)
            {
                // _barberCoupon.IsSuccess = false; 
                // _barberCoupon.Message = ex.Message;
                // Dto will come here
                barberCoupon.BarberCouponCode = "Something went wrong";

            }

            return barberCoupon;


        }


    }

}