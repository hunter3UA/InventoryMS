using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMS.Mapper;
using InventoryMS.Models.DTO;
using InventoryMS.DAL;
using InventoryMS.Models.Entity;
using AutoMapper;

namespace InventoryMS.Services
{
    public class ProductService:IProductService
    {
        private IMapper _mapper;
        public ProductService()
        {
            _mapper = AutoMapperConfig.Configure().CreateMapper();
        }
        public async Task<ProductDTO> Create(ProductCreateDTO productCreateDTO)
        {
            Product newProduct = _mapper.Map<Product>(productCreateDTO);
            newProduct.ProductUnit = new Unit { UnitID = productCreateDTO.ProductUnitID };
            Product addedProduct = await _DAL.Products.Add(newProduct);
            return _mapper.Map<ProductDTO>(addedProduct);
        }
        public async Task<List<ProductDTO>> All()
        {
            List<Product> allProducts = await _DAL.Products.All();
            return _mapper.Map<List<ProductDTO>>(allProducts);
               
        }
        public async Task<ProductDTO> ByID(int productID)
        {
            Product productByID = await _DAL.Products.ByID(productID);
            return _mapper.Map<ProductDTO>(productByID);

        }
        public async Task<ProductDTO> Update(ProductUpdateDTO productUpdateDTO)
        {
            Product productToUpdate = _mapper.Map<Product>(productUpdateDTO);
            productToUpdate.ProductUnit = new Unit { UnitID = productUpdateDTO.ProductUnitID };
            Product updatedProduct = await _DAL.Products.Update(productToUpdate);
            return _mapper.Map<ProductDTO>(updatedProduct);
        }
        public async Task<bool> DeleteByID(int productID)
        {        
            return await _DAL.Products.DeleteByID(productID);
        }

    }
}
