using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_DataAccessLayer.Interfaces
{
    public interface IProductRepository
    {
        //Task<bool> AddProdcut(Product product);

        Task<List<Product>> GetAllProductsAsync();

    }
}
