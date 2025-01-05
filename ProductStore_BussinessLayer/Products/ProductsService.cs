 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ProductStore_BussinessLayer.Dtos;
using ProductStore_BussinessLayer.Mapper;
using ProductStore_DataAccessLayer;
using ProductStore_DataAccessLayer.Interfaces;
using ProductStore_DataAccessLayer.Repository;

namespace ProductStore_BussinessLayer.Products
{
    public class ProductsService : IProductsService
    {

        private readonly  IProductRepository _repository;


        public ProductsService(IProductRepository Repository)
        {
            _repository = Repository;
        }

        public async Task<List<ProductDTO>> GetAllProductsAsync()
        {
            var Products= await _repository.GetAllProductsAsync();
           var ProductsDTO=  Products.Select(x => x.ToDTO()).ToList();
            return ProductsDTO;

        }

        //public async Task<bool> AddProdcut(ProductDTO product)
        //{
            
        //    var Product = product.ToProduct();
        //    return await _repository.AddProdcut(Product);
        //}


    }
}
