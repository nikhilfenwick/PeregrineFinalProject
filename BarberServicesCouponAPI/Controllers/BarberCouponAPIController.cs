using AutoMapper;
using BarberServicesCouponAPI.Data;
using BarberServicesCouponAPI.Models;
using BarberServicesCouponAPI.Models.DTO;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BarberServicesCouponAPI.Controllers
{
    [Route("api/BarberCoupons")]
    [ApiController]
    // Authorise will come here later

    public class BarberCouponApiController : ControllerBase
    {
        private readonly AppDBContext _db;
        private ResponseDTO _response;
        private IMapper _mapper;
        
        public BarberCouponApiController(AppDBContext db, IMapper mapper)
        {
            _db = db;
            _response = new ResponseDTO();
            _mapper = mapper;
            // DTO and Mapper will come here
        
        }

        [HttpGet]
        [Route("APICheck")]
        public ResponseDTO APICheck()
        {
            try 
            {
                APICheckInfo apiCheckInfo = new APICheckInfo();
                apiCheckInfo.APICheckInformation = "This messsage means the API is working";
                _response.Result = _mapper.Map<APICheckInfoDTO>(apiCheckInfo);
            }   
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }     
            // var checkString = "This messsage means the API is working";
            return _response;
        }

        // Getting the entire list of Barber Coupons
        [HttpGet]
        [Route("GetAllBarberCoupons")]
        public ResponseDTO GetListofBarberCoupons()
        {
            try 
            {
                IEnumerable<BarberCoupon> barberCoupons = _db.barberCoupons.ToList();
                _response.Result = _mapper.Map<IEnumerable<BarberCouponDTO>>(barberCoupons);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        } 

        [HttpPost]
        // Authorise will come here
        [Route("AddingBarberCoupon")]
        public ResponseDTO Post([FromBody] BarberCouponDTO barberCouponDTO)
        {
            try 
            {
                BarberCoupon barberCoupon = _mapper.Map<BarberCoupon>(barberCouponDTO);
                _db.barberCoupons.Add(barberCoupon);
                _db.SaveChanges();
                _response.Result = _mapper.Map<BarberCouponDTO>(barberCoupon);

            }

            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;                
            }
            return _response;
        }

        [HttpPut]
        [Route("UpdatingBarberCoupon")]

        public ResponseDTO Put([FromBody] BarberCouponDTO barberCouponDTO)
        {
            try 
            {
                
                BarberCoupon barberCoupon = _mapper.Map<BarberCoupon>(barberCouponDTO);
                _db.barberCoupons.Update(barberCoupon);
                _db.SaveChanges();
                _response.Result = _mapper.Map<BarberCouponDTO>(barberCoupon);

            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message; 
            }

            return _response;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ResponseDTO Delete(int id)
        {
            BarberCoupon barberCoupon = new BarberCoupon();
            try 
            {
                barberCoupon = _db.barberCoupons.First(u => u.BarberCouponId == id); 
                _db.barberCoupons.Remove(barberCoupon);
                _db.SaveChanges();
                _response.Result = _mapper.Map<BarberCouponDTO>(barberCoupon);

            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message; 

            }
            
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]

        public ResponseDTO GetByCode(int id)
        {
            BarberCoupon barberCoupon = new BarberCoupon(); 
            try
            {    

            barberCoupon  = _db.barberCoupons.First(u => u.BarberCouponId == id);
            _response.Result = _mapper.Map<BarberCouponDTO>(barberCoupon);

            }

            catch (Exception ex)
            {
                _response.IsSuccess = false; 
                _response.Message = ex.Message;
                

            }

            return _response;


        }


    }

}