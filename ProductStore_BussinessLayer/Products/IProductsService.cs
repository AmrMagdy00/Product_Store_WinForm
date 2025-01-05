using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_BussinessLayer.Dtos;

namespace ProductStore_BussinessLayer.Products
{
    public interface IProductsService
    {
     //   Task<bool> AddProdcut(ProductDTO product);

        Task<List<ProductDTO>> GetAllProductsAsync();

    }
}
