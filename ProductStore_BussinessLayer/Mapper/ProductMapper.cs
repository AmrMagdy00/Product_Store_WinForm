using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_BussinessLayer.Dtos;
using ProductStore_DataAccessLayer;

namespace ProductStore_BussinessLayer.Mapper
{
    public static class ProductMapper
    {
        public static ProductDTO ToDTO(this Product product)
        {
            ProductDTO dto = new ProductDTO ();
            dto.Id = product.Id;
            dto.Title = product.Title;
            dto.Description = product.Description;

            dto.Price=product.Price;
            dto.ImageUrl = product.ImageUrl;

            dto.Category = product.Category.Name;
            dto.InStock = product.InStock;

            return dto;
        }

        public static Product ToProduct(this ProductDTO DTO)
        {
            Product product = new Product();
            DTO.Id = product.Id;
            DTO.Title = product.Title;
            DTO.Description = product.Description;

            DTO.Price = product.Price;
            DTO.ImageUrl = product.ImageUrl;

            DTO.Category = product.Category.Name;
            DTO.InStock = product.InStock;

            return product;
        }

    }
}
