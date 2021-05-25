using InventoryMS.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMS.Models.DTO;

namespace InventoryMS.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/v1/Products
        [HttpGet]
        public async Task<List<ProductDTO>> Get()
        {
            return await _productService.All();
        }

        // GET api/v1/5
        [HttpGet("{id}")]
        public async Task<ProductDTO> Get(int id)
        {
            return await _productService.ByID(id);
        }

        // POST api/v1/Products
        [HttpPost]
        public async Task<ProductDTO> Post([FromBody] ProductCreateDTO productCreateDTO)
        {
            return await _productService.Create(productCreateDTO);
        }

        // PUT api/v1/5
        [HttpPut]
        public async Task<ProductDTO> Put( [FromBody] ProductUpdateDTO productUpdateDTO)
        {
            return await _productService.Update(productUpdateDTO);

        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)            
        {
            return await _productService.DeleteByID(id);
        }
    }
}
