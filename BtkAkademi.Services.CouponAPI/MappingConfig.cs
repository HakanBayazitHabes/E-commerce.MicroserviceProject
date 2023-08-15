using AutoMapper;
using BtkAkademi.Services.CouponAPI.Models;
using BtkAkademi.Services.CouponAPI.Models.Dto;

namespace BtkAkademi.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();

            });

            return mappingConfig;
        }
    }
}
