using AutoMapper;
using BarberServicesCouponAPI.Models;
using BarberServicesCouponAPI.Models.DTO;

namespace BarberServicesCouponAPI

{
    //configuring the automatter to map between the db class and dto class
    //this can be done manually too. 
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<BarberCouponDTO, BarberCoupon>();
                config.CreateMap<BarberCoupon, BarberCouponDTO>();
            });
            return mappingConfig;
        }
    }
}