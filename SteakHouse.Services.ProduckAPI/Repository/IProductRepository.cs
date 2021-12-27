using SteakHouse.Services.ProduckAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SteakHouse.Services.ProduckAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProductById(int productId);
        Task<ProductDTO> CreateUpdateProduct(ProductDTO productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
