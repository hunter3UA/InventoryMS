using InventoryMS.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMS.Services
{
    public interface IProductService
    {
        Task<ProductDTO> Create(ProductCreateDTO productCreateDTO);
        Task<List<ProductDTO>> All();
        Task<ProductDTO> ByID(int productID);
        Task<ProductDTO> Update(ProductUpdateDTO productUpdateDTO);
        Task<bool> DeleteByID(int productID);

    }
}
