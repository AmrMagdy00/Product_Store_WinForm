using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_DataAccessLayer;

namespace ProductStore_BussinessLayer.Dtos
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public int InStock { get; set; }
    }
}
