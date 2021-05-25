using InventoryMS.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMS.Services
{
    public interface IUnitService
    {
        Task<List<UnitDTO>> All();
    }
}
