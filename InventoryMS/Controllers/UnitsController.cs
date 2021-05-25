using InventoryMS.Models.DTO;
using InventoryMS.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController : ControllerBase
    {
        private IUnitService _unitService;
        public UnitsController(IUnitService unitService)
        {
            _unitService = unitService;
        }
        // GET: api/<UnitsController>
        [HttpGet]
        public async Task<List<UnitDTO>> Get()
        {
            return await _unitService.All();
        }

        
    }
}
