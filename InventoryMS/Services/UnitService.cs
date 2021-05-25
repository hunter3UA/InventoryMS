using AutoMapper;
using InventoryMS.DAL;
using InventoryMS.Mapper;
using InventoryMS.Models.DTO;
using InventoryMS.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMS.Services
{
    public class UnitService:IUnitService
    {
        private IMapper _mapper;
        public UnitService()
        {
            _mapper = AutoMapperConfig.Configure().CreateMapper();
        }
        public async Task<List<UnitDTO>> All()
        {
            List<Unit> allUnits = await _DAL.Units.All();
            return _mapper.Map<List<UnitDTO>>(allUnits);
        }
    }
}
