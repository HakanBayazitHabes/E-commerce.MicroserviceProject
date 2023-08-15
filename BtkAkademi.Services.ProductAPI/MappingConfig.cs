using AutoMapper;
using BtkAkademi.Services.ProductAPI.Models;
using BtkAkademi.Services.ProductAPI.Models.Dto;

namespace BtkAkademi.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
