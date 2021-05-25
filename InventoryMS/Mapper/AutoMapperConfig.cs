using AutoMapper;
using InventoryMS.Models.DTO;
using InventoryMS.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMS.Mapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration Configure()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Product, ProductDTO>();
                    cfg.CreateMap<ProductCreateDTO, Product>();
                    cfg.CreateMap<ProductUpdateDTO, Product>();

                    cfg.CreateMap<Unit, UnitDTO>();
                    

                    
                   

                });
            return config;
        }
    }
}
